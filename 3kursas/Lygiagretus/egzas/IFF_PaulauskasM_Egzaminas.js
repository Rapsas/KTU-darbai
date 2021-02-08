const { start, dispatch, spawnStateless, spawn } = require('nact');
const system = start();

const fs = require('fs');
const sha256 = require("crypto-js/sha256");

const data = require("./IFF_8-13_PaulauskasM_L1_dat_3.json");
const resultFile = 'IFF_8-13_PaulauskasM_L1_rez_1.txt';
const darbininkai = [];
console.log("Processing data");

function compareStudents(student1, student2) {
    if (student1.year === student2.year) {
        return student1.grade >= student2.grade;
    } else {
        return student1.year > student2.year;
    }
}

const kaupiklis = spawn(
    system, 
    (state = {}, msg, ctx) => {
        const hasFinished = msg.isDone !== undefined
        const firstTimeCalled = state["firstTime"] === undefined;

        if(hasFinished) {
            const arr = state["array"];
            dispatch(skirstytuvas, {sendToKaupiklis: true, array: arr});
        }
        else if (firstTimeCalled) { // First time
            const arr = [];
            arr.push(msg);     
            return { ...state, ["firstTime"]: true, ["array"]: arr }
        }
        else {
            const arr = state["array"];    // Store recieved item in acumulator
            arr.push(msg);
            arr.sort((a,b) => compareStudents(a, b) ? 1 : -1);
            return state;
        }
    },
    'kaupiklis'
);

const spausdintuvas = spawnStateless(system,
    (msg, ctx) => {
        console.log("Writing results");
        const results = msg.array;
        const header = "Name".padEnd(15) + " | " + "Year".padEnd(5) + " | " + "Grade".padEnd(5) + " | " + "Hash\n"

        fs.unlink(resultFile, (err) => { });
        fs.appendFileSync(resultFile, header, (err) => { if (err) throw err; });

        results.forEach(rez => {
            const year = rez.year.toString();
            const grade = rez.grade.toString();
            const line = rez.name.padEnd(15) + " | " + year.padEnd(5) + " | " + grade.padEnd(5) + " | " + rez.hash + '\n';
            fs.appendFileSync(resultFile, line, (err) => { if (err) throw err; });
        });
        console.log("Finished writing results");
    },
    'spausdintuvas'
);

const skirstytuvas = spawn(system, 
    (state = {index: 0, workers: 0, dataCounter: 0 }, msg, ctx) => {
        const hasFinished = msg.isDone !== undefined;
        const fromWorker = msg.kaupiklis !== undefined;
        const SendDataToSpausdintojas = msg.sendToKaupiklis !== undefined;

        if (hasFinished) { // Requesting Kaupiklis to give data back
            dispatch(kaupiklis, msg);
        }
        else if (fromWorker) { // Message from darbininkas
            if (msg.kaupiklis) { // Result is sent to Kaupiklis
                dispatch(kaupiklis, msg)
            }

            const count = +state["workers"] - 1; // Decrease counter
            state = {...state, ["workers"]: count}
            if (count == 0 && +state["dataCounter"] == data.length) { // Last working worker is finishing
                dispatch(skirstytuvas, {isDone: true})
            }
        }
        else if (SendDataToSpausdintojas){
            dispatch(spausdintuvas, msg);
        }
        else {
            dispatch(darbininkai[state["index"] % darbininkai.length], msg); //Send data to workers
            
            const index = 1 + +state["index"]
            const countWorking = 1 + +state["workers"];
            const countData = 1 + +state["dataCounter"];
            state = {...state, ["workers"]: countWorking, ["dataCounter"]: countData, ["index"]: index}
        }
        return state;
        },
    'skirstytuvas'
);

[...Array(data.length/4).keys()].forEach(elm => { // Creates workers
    darbininkai.push(spawnStateless(
        system, 
        async (msg, ctx) => {
            const tmp_arr = [msg.name];
            [...Array(1000).keys()].forEach(elm => {
                const hash = sha256(tmp_arr.pop() + msg.name + msg.year + msg.grade + msg.username);
                tmp_arr.push(hash);
            }); 
            const hash1 = tmp_arr.pop();
            
            // Filter data
            if (msg.grade >= 7) {
                dispatch(skirstytuvas, {kaupiklis: true, hash: hash1, ...msg});
            } else {
                dispatch(skirstytuvas, {kaupiklis: false});
            }
        },
        elm.toString()
    )); 
});

// Gives elements to the splitter
data.forEach((x) => dispatch(skirstytuvas, x));