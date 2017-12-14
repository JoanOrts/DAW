<?php 
session_start();
require_once("comprobarSesion.php");
$title="Detalle Foto. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
?>

<main>

<?php
$sentcomprobar = "select max(IdAlbum) as Patata from ALBUMES";
$numero = mysqli_query($mysqli, $sentcomprobar);
if(!$numero || $mysqli->errno){
	die("Error: No se pudo realizar la consulta".$mysqli->error);
}
$numeros=$numero->fetch_assoc();
if($_GET['id']>$numeros['Patata']){
	echo "<article class='mensajerror'><p>No existe.</p></article>";
}
else{
	$sentencia = "select * from ALBUMES a where IdAlbum=".$_GET['id'];
	$albumes = mysqli_query($mysqli, $sentencia);
	if(!$albumes || $mysqli->errno){
		die("Error: No se pudo realizar la consulta".$mysqli->error);
	}
	$sentuser = "select USUARIOS.* from USUARIOS, ALBUMES where ALBUMES.Usuario = USUARIOS.IdUsuario and ALBUMES.IdAlbum=".$_GET['id'];
	$usuarios = mysqli_query($mysqli, $sentuser);
	if(!$usuarios || $mysqli->errno){
		die("Error: No se pudo realizar la consulta".$mysqli->error);
	}
	$usuario=$usuarios->fetch_assoc();

	
	$sentfoto = "select * from FOTOS f where Album=".$_GET['id'];
	$fotos = mysqli_query($mysqli, $sentfoto);
	if(!$fotos || $mysqli->errno){
		die("Error: No se pudo realizar la consulta".$mysqli->error);
	}

	$albumes=$albumes->fetch_assoc();
	echo "<h2>Visualizando album ".$albumes['Titulo']."</h2><br>";
	echo "<p class='albumdatos'><strong>Subidor por: </strong>".$usuario['NomUsuario']."  |    <strong>Fecha: </strong>".$albumes['Fecha']."   |   <strong>Descripción: </strong>".$albumes['Descripcion']."</p><br>";
	echo "<section class='seccionfotos'>";
	while($fto = mysqli_fetch_array($fotos)){   
		echo "<a href='DetalleFoto.php?id=".$fto['IdFoto']."'><img src='".$fto['Fichero']."' alt='".$fto['Titulo']."' width=400></a>";  
	}
	echo "</section>";

	
}

?>
</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
