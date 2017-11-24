<?php
require_once("conexionbd.php");
if(isset($_POST)&&isset($_POST["usuario"])){

$usuario = $_POST["usuario"];
$contrasenya = $_POST["contrasena"];

$sentencia = "select * from USUARIOS where NomUsuario='".$_POST['usuario']."'";
$todo_usu = mysqli_query($mysqli, $sentencia);
if(!$todo_usu || $mysqli->errno){
	die("Error: No se pudo realizar la consulta".$mysqli->error);
}
$usuarios=$todo_usu->fetch_assoc();

	if(($usuarios['NomUsuario'] == $usuario) && ($usuarios['Clave'] == $contrasenya)){
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
