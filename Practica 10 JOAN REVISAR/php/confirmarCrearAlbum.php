<?php
session_start();
require_once("comprobarSesion.php");
$title="Confirmación Creación Album - PI Images y Picturas";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");


$online;
if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
	$usuarios = explode(":",$_COOKIE['usuario']);
	$online = $usuarios[0];
}
else{

	$online= $_SESSION["user"];

}

$sentusuario = "select * from USUARIOS where NomUsuario='".$online."'";
$users = mysqli_query($mysqli, $sentusuario);
if(!$users || $mysqli->errno){
	die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta".$mysqli->error);
}
$usuario=$users->fetch_assoc();

if(isset($_POST["titulo"])){
	$sentencia="INSERT INTO ALBUMES (Titulo, Descripcion, Fecha, Pais, Usuario) values ('".$_POST["titulo"]."'";

	if(isset($_POST["descripcion"])){
		$sentencia=$sentencia.", '".$_POST["descripcion"]."'";
	}
	else{
		$sentencia=$sentencia.", ''";
	}
	if(isset($_POST["fecha"])){
		$sentencia=$sentencia.", '".$_POST["fecha"]."'";
	}
	else{
		$sentencia=$sentencia.", ''";
	}
	if(isset($_POST["pais"])){
		$sentencia=$sentencia.", ".$_POST["pais"].",".$usuario['IdUsuario'].");";
	}
	mysqli_query($mysqli, $sentencia);
}
else{
}

?>
<main>
    <h2>Album creado correctamente</h2>
		<div class="mensajerror"><nav>
				<a href="usuarioRegistrado.php">Volver a mi usuario</a>
		</nav></div>
</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
