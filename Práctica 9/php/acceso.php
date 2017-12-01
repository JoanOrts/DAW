<?php
require_once("conexionbd.php");
if(isset($_GET["salir"])){
		session_destroy();
		setcookie('usuario','', time()-999999);
		setcookie('date','', time()-999999);
		header("location:index.php");
	}

	if(isset($_GET["entrar"])){
		$array_usuarios = explode(":",$_COOKIE['usuario']);
		$sentencia="select * from USUARIOS where NomUsuario='".$array_usuarios[0]."' and Clave='".$array_usuarios[1]."';";
		$usuarios=mysqli_query($mysqli, $sentencia);
		if($user=$usuarios->fetch_assoc()){
			$_SESSION["Estado"]="Autenticado";
			$date= isset($_COOKIE['date']);
			$fecha=date("j/m/Y - G:i");
			setcookie('date',$fecha,time() +60*60*7);
			header("location:index.php");
		}
		else{
			header("location:index.php?error");
		}
   	 }

    	if(isset($_GET["olvidar"])){
		setcookie('usuario','', time()-999999);
		setcookie('date','', time()-999999);
			header("location:index.php");
   	 }
?>
