<?php
$usu1 = "joan7";
$con1 = "dawmola";
$usu2 = "carlos7";
$con2 = "jajaja";
$usu3 = "sergio7";
$con3 = "teneisun10";

if(isset($_POST)&&isset($_POST["usuario"])){

$usuario = $_POST["usuario"];
$contrasenya = $_POST["contrasena"];

	if(($usuario == $usu1 && $contrasenya == $con1) || ($usuario == $usu2 && $contrasenya == $con2) || ($usuario == $usu3 && $contrasenya == $con3)){
		if(isset($_POST['Recordarme'])){
		                $date= isset($_COOKIE['date']);
		                $fecha=date("j/m/Y - G:i");
		                setcookie('usuario',$usuario.":".$contrasenya, time()+60*60*7);
		                setcookie('date',$fecha,time() +60*60*7);   
	    	}
	  	header("Location: http://localhost/DAW/php/usuarioRegistrado.php");
		$_SESSION["Estado"]="Autenticado";
		$_SESSION["user"]=$usuario;
	}
	
	else{
	  header("Location: http://localhost/DAW/php/index.php?error");
	}
}

?>
