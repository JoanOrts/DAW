<?php
session_start();
require_once("comprobarSesion.php");
$title="Perfil. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
if(isset($_GET["borrar"])){
	$sentencia="DELETE FROM USUARIOS WHERE USUARIOS.NomUsuario='".$_SESSION["user"]."';";
	mysqli_query($mysqli, $sentencia);
  session_destroy();
	header("location:index.php");
}
?>
<main>
  <h2>¿Estás seguro de borrar definitivamente tu cuenta?</h2>
    <div class="botonet2"><input type="submit" value="Borrar la cuenta" onclick="location='darmeBaja.php?borrar'"></div>
    <div class="botonet2"><input type="submit" value="Volver" onclick="location='usuarioRegistrado.php'"></div>
</main>
<?php
require_once("footer.php");
?>
