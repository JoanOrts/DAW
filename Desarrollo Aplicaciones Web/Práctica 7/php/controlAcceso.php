<?php
session_start();
$usuario = $_POST["usuario"];
$contrasenya = $_POST["contrasena"];
$usu1 = "joan7";
$con1 = "dawmola";
$usu2 = "carlos7";
$con2 = "jajaja";
$usu3 = "sergio7";
$con3 = "teneisun10";
if($usuario == $usu1 && $contrasenya == $con1){
	if(isset($_POST['Recordarme'])){
		$date = isset($_COOKIE['date']);
		$fecha = date("F j, Y, g:i a");
		setcookie('usuario',$usuario.":".$contrasenya, time()+60*60*7);
		setcookie('date',$fecha,time() +60*60*7); 
	}
  	header("Location: http://localhost/DAW/php/usuarioRegistrado.php?user=$usu1");
	$_SESSION["Estado"]="Autenticado";
}
elseif($usuario == $usu2 && $contrasenya == $con2){
	if(isset($_POST['Recordarme'])){
		$date = isset($_COOKIE['date']);
		$fecha = date("F j, Y, g:i a");
		setcookie('usuario',$usuario.":".$contrasenya, time()+60*60*7);
		setcookie('date',$fecha,time() +60*60*7); 
	}
  	header("Location: http://localhost/DAW/php/usuarioRegistrado.php?user=$usu2");
	$_SESSION["Estado"]="Autenticado";
}
elseif($usuario == $usu3 && $contrasenya == $con3){
	if(isset($_POST['Recordarme'])){
		$date = isset($_COOKIE['date']);
		$fecha = date("F j, Y, g:i a");
		setcookie('usuario',$usuario.":".$contrasenya, time()+60*60*7);
		setcookie('date',$fecha,time() +60*60*7); 
	}
  	header("Location: http://localhost/DAW/php/usuarioRegistrado.php?user=$usu3");
	$_SESSION["Estado"]="Autenticado";
}
else{
  header("Location: http://localhost/DAW/php/index.php?error");
}

?>
