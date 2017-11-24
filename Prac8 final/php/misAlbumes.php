<?php 
session_start();
require_once("comprobarSesion.php");
$title="Detalle Foto. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
?>
		<main>
			<h2>Mis Albumes</h2>
			
			


	<?php
	$el_usuario;
	if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
		$usuarios = explode(":",$_COOKIE['usuario']);
		$el_usuario = $usuarios[0];
	}
	else{

		$el_usuario = $_SESSION["user"];

	}

	$sentencia = "select ALBUMES.* from ALBUMES, USUARIOS where ALBUMES.Usuario = USUARIOS.IdUsuario and USUARIOS.NomUsuario='".$el_usuario."';";
	$query = mysqli_query($mysqli, $sentencia);
	$albumes = array(); // create a variable to hold the information
	while (($row = mysqli_fetch_array($query, MYSQLI_ASSOC))){
  		$albumes[] = $row; // add the row in to the results (data) array
	}

	if(!$albumes || $mysqli->errno){
		die("Error: No se pudo realizar la consulta".$mysqli->error);
	}


	for ($i = 0; $i < count($albumes); $i++) {
		$id=$albumes[$i]['IdAlbum'];
		$sentfoto = "select * from FOTOS f where Album='".$id."';";
		$fotos = mysqli_query($mysqli, $sentfoto);
		if(!$fotos || $mysqli->errno){
			die("Error: No se pudo realizar la consulta".$mysqli->error);
		}

		$foto=$fotos->fetch_assoc();
		echo "<figure class='fotografia'><a href='visualizaralbum.php?id=".$id."'><img src='".$foto['Fichero']."' alt='".$foto['Titulo']."' width=400></a>";
		echo "<ul>
			<li>Album: "."<a href='visualizaralbum.php?id=".$id."' style='color: #12B8FF;'>".$albumes[$i]['Titulo']."</a>"."</li>
			<li>Fecha: ".$albumes[$i]['Fecha']."</li>
			<li>Descripcion: ".$albumes[$i]['Descripcion']."</li>
			</ul>			
			</figure><br>";
	}
	
	?>
</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
