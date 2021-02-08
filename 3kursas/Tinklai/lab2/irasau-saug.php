<?php
$server = "localhost";
$db = "pvz";
$user = "stud";
$password = "stud";
$lentele = "studentas";

$conn = new mysqli($server, $user, $password, $db);
if($conn->connect_error) die("Negaliu prisijungti: " . $conn->connect_error);

if($_POST !=null){
// įrašyti reikšmes iš formos

    $vardas = substr($_POST['vardas'],0,19); 						// kad tilptų - nukerpam
    if (preg_match("#^[a-zA-ZĄČĘĖĮŠŲŪŽąčęėįšųūž]+$#", $vardas)){ 	// jei ne lietuviškas vardas- neįrašyti
        $epastas =$_POST['epastas'];  								// pasitikim type="email"
        $zinute = htmlspecialchars($_POST['zinute']);  				//perrašo html simbolius kodais
        // prepare and bind
        $stmt = $conn->prepare("INSERT INTO $lentele (vardas, epastas, zinute) VALUES (?, ?, ?)");
        if ( false===$stmt ) {die("Negaliu įrašyti, prepare() klaida: " . $conn->error);}
        $stmt->bind_param("sss", $vardas, $epastas, $zinute);
        if(!$stmt->execute()){die("Negaliu įrašyti, execute() klaida: " .$stmt->error);}
    }}
$conn->close();
header("Location:skaitau.php");exit;
?>