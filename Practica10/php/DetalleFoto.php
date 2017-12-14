<?php 
session_start();
require_once("comprobarSesion.php");
$title="Detalle Foto. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
?>
		<main>
			<h2>Detalles de la foto</h2>
			
			


	<?php
		if(isset($_GET['id'])){
			
				$sentencia = "select * from FOTOS f where IdFoto=".$_GET['id'];
				$fotos = mysqli_query($mysqli, $sentencia);
				if(!$fotos || $mysqli->errno){
					die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta");
				}
				$foto=$fotos->fetch_assoc();
				$sentpais= "select * from PAISES p where IdPais=".$foto['Pais'];
				$paises=mysqli_query($mysqli, $sentpais);
				if(!$paises || $mysqli->errno){
					die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta</p></article>");
				}
				$pais=$paises->fetch_assoc();
				$sentusuario = "select USUARIOS.* from USUARIOS, ALBUMES where USUARIOS.IdUsuario = ALBUMES.Usuario and ALBUMES.IdAlbum = ".$foto['Album'];
				$usuarios = mysqli_query($mysqli, $sentusuario);
				if(!$usuarios || $mysqli->errno){
					die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta</p></article>");
				}
				$usuario = $usuarios->fetch_assoc();	
				$sentalbum = "select * from ALBUMES where ALBUMES.IdAlbum = ".$foto['Album'];
				$albumes = mysqli_query($mysqli, $sentalbum);
				if(!$albumes || $mysqli->errno){
					die("<article class='mensajerror'><p>Error: No se pudo realizar la consulta</p></article>");
				}
				$album = $albumes->fetch_assoc();
					
				echo "<figure class='fotografia'><img src='".$foto['Fichero']."' alt='".$foto['Titulo']."'width=400>
					<ul>
					    <li>Título: ".$foto['Titulo']."</li>
					    <li>Fecha: ".$foto['Fecha']."</li>
					    <li>País: ".$pais['NomPais']."</li>
					    <li>Álbum: <a href='album.php?id=".$album['IdAlbum']."'>".$album['Titulo']."</a></li>
					    <li>Usuario: <a href='otroUsuario.php?user=".$usuario['NomUsuario']."'>".$usuario['NomUsuario']."</a></li>
					</ul>
					</figure>";
			
		}
		?>




		</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
