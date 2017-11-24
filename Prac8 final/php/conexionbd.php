<?php 
	$mysqli = new mysqli("localhost", "pibd", "pibdpassword", "pibd");
	if(!mysqli_ping($mysqli)){
		die("Error: No se ha podido conectar con la base de datos");
	}
	$mysqli->set_charset("utf8");
?>
