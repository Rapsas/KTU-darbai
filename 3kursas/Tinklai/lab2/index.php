<?php

$server="localhost";
$user="stud";
$password="stud";
$dbname="stud";

// prisijungti
$conn = new mysqli($server, $user, $password, $dbname);
if ($conn->connect_error) die("Negaliu prisijungti: " . $conn->connect_error);

if($_POST !=null)
{
    $vardas = $_POST['vardas'];
    $epastas = $_POST['epastas'];
    $kam = $_POST['kam'];
    $zinute = $_POST['zinute'];
    $miestas = $_POST['miestas'];
    if ($_POST['trynti'] != ""){
        $sql = 'DELETE FROM mykolaspaulauskas WHERE (vardas="'.$_POST['trynti'].'")';
        if (!$result = $conn->query($sql)) die("Negaliu įrašyti: " . $conn->error);
    }


    $sql = 'INSERT INTO mykolaspaulauskas (vardas, epastas, kam, data, ip, zinute, miestas) 
             VALUES ("'.$vardas.'", "'.$epastas.'", "'.$kam.'", NOW() , "'.$_SERVER['REMOTE_ADDR'].'" ,"'.$zinute.'","'.$miestas.'")';

    if (!$result = $conn->query($sql)) die("Negaliu įrašyti: " . $conn->error);
    $conn->close();
    header("location: index.php");
    exit();
}

?>

<!DOCTYPE html>
<html>

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js">
    </script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js">
    </script>
    <style>
        #zinutes{
            font-family: Arial;
            border-collapse: collapse;
            width: 70%;
        }
        #zinutes td{
            border: 1px solid #ddd;
            padding: 8px;
        }
        #zinutes tr:nth-child(even){background-color:#f2f2f2;}
        #zinutes tr:hover{background-color: #ddd;}

        .uzrasas {
            color: green;
        }
    </style>

    <title>Laboratorinis darbas 2</title>


</head>

<body>
<center><h3 class="uzrasas">Žinučių sistema</h3></center>
<table style="margin: 0px auto;" id="zinutes">
    <tr>
        <td>Nr</td>
        <td>Kas siuntė</td>
        <td>Siuntėjo e-paštas</td>
        <td>Gavėjas</td>
        <td>Data(IP)</td>
        <td>Žinutė</td>
        <td>Miestas</td>
    </tr>
    <?php
    //  nuskaityti
    $sql =  "SELECT * FROM mykolaspaulauskas";
    if (!$result = $conn->query($sql)) die("Negaliu nuskaityti: " . $conn->error);

    while($row = $result->fetch_assoc())
    {
        echo "<tr>
						<td>".$row['id']."</td>
						<td>".$row['vardas']."</td>
						<td>".$row['epastas']."</td>
						<td>".$row['kam']."</td>
						<td>".$row['data']."(".$row['ip'].")</td>
						<td>".$row['zinute']."</td>
						<td>".$row['miestas']."</td>
					</tr>";
    }

    $conn->close();
    ?>
</table>

<center><h4>Įveskita naują žinutę</h4></center>
<div class="container">
    <form method='post'>
        <div class="form-group col-lg-4">
            <label for="vardas" class="control-label">Siuntėjo vardas:</label>
            <input name='vardas' type='text' class="form-control input-sm">
        </div>
        <div class="form-group col-lg-4">
            <label for="epastas" class="control-label">Siuntėjo e-paštas:</label>
            <input name='epastas' id="epastas" type='email' class="form-control input-sm">
        </div>
        <div class="form-group col-lg-4">
            <label for="kam" class="control-label">Kam skirta:</label>
            <input name='kam' type='text' class="form-control input-sm">
        </div>
        <div class="form-group col-lg-4">
            <p>Pasitinkine miesta</p>
            <input type="radio" id="Kaunas" name="miestas" value="Kaunas">
            <label for="Kaunas">Kaunas</label><br>
            <input type="radio" id="Vilnius" name="miestas" value="Vilnius">
            <label for="Vilnius">Vilnius</label><br>
            <input type="radio" id="Klaipeda" name="miestas" value="Klaipeda">
            <label for="Klaipeda">Klaipeda</label>
        </div>
        <div class="form-group col-lg-12">
            <label for="zinute" class="control-label">Žinutė:</label>
            <textarea name='zinute' class="form-control input-sm"></textarea>
        </div>
        <div class="form-group col-lg-12">
            <label for="trynti" class="control-label">Ka istrynti:</label>
            <textarea name='trynti' class="form-control input-sm"></textarea>
        </div>
        <div class="form-group col-lg-2">
            <input type='submit' name='ok' value='siųsti' class="btnbtn-default">
        </div>
    </form>
</div>
</body>


</html>