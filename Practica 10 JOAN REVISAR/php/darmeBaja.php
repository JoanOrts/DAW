<?php
session_start();
require_once("comprobarSesion.php");
$title="Perfil. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
if(isset($_GET["borrar"])){
	/*$sentusuario = "select * from USUARIOS WHERE NomUsuario='".$_SESSION["user"]."';";
	$usuarios = mysqli_query($mysqli, $sentusuario);
	if(!$usuarios || $mysqli->errno){
		die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta</p></article>".$mysqli->error);
	}
	$usuario = $usuarios->fetch_assoc();

	$idusuario = $usuario['IdUsuario'];

	$sentalbumess = "select ALBUMES.* from ALBUMES WHERE Usuario='".$idusuario."';";
	$albumess = mysqli_query($mysqli, $sentalbumess);
	if(!$usuarios || $mysqli->errno){
		die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta</p></article>".$mysqli->error);
	}
	$idalbums = $albumess->fetch_assoc();

	$idalbum = $idalbums['IdAlbum'];
	

	$sentfoto="DELETE FROM FOTOS WHERE Album ='".$idalbum."';";
	mysqli_query($mysqli, $sentfoto);
	$sentalbum="DELETE FROM ALBUMES WHERE Usuario ='".$idusuario."';";
	mysqli_query($mysqli, $sentalbum);*/
	$sentencia="DELETE FROM USUARIOS WHERE USUARIOS.NomUsuario='".$_SESSION["user"]."';";
	mysqli_query($mysqli, $sentencia);
  	session_destroy();
	header("location:index.php");
}
?>
<main>
  <h2>¿Estás seguro de borrar definitivamente tu cuenta?</h2>
	<div><section class="mensajerror">
	    <div class="botonet2"><input type="submit" value="Borrar la cuenta" onclick="location='darmeBaja.php?borrar'"></div><br>
	    <div class="botonet2"><input type="submit" value="Volver" onclick="location='usuarioRegistrado.php'"></div>
	</section></div>
</main>
<?php
require_once("footer.php");
?>
