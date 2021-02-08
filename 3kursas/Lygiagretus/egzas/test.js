const { start, spawnStateless, dispatch } = require('nact');
const system = start();

const greeter = spawnStateless(system, (msg) => console.log(`Hello ${msg.name}`), 'greeter');
dispatch(greeter, { name: 'Erlich Bachman' });

const delay = (time) => new Promise((res) => setTimeout(res, time));

const ping = spawnStateless(system, async (msg, ctx) =>  {
  if(msg.value)
  {
    await delay(5000);
  }
  else
  {
    await delay(3000);
  }
  
  console.log(Date.now().toString());
  // ping: Pong is a little slow. So I'm giving myself a little handicap :P
  //dispatch(msg.sender, { value: ctx.name, sender: ctx.self });
}, 'ping');

const pong = spawnStateless(system, async (msg, ctx) =>  {
  await delay(3000);
  console.log(Date.now().toString());
  //console.log(ctz.name);
  //dispatch(msg.sender, { value: ctx.name, sender: ctx.self });
}, 'pong');

dispatch(ping, { value: true });
dispatch(ping, { value: false });