<?php
session_start();
require_once("comprobarSesion.php");
$title="Crear álbum. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
?>
<main>
    <h2>Formulario creación album</h2>
		<p>Introduce los siguientes datos. Los campos con (*) son obligatorios:</p>
		<form class="formulariobusqueda" method="POST" action="confirmarAnyadirFoto.php">
			<label for="titulo">Título:</label> <input type="text" name="titulo" id="titulo" placeholder="Título de la foto" required>(*)<br>
			<label for="descripcion">Descripción:</label><textarea name="descripcion" id="descripcion" maxlength="4000" rows="4" cols="50" placeholder="Introduzca una descripción del album"></textarea><br>
			<label for="fecha">Fecha:</label> <input type="date" name="fecha" id="fecha"><br>
			<?php
				$sentencia="select * from PAISES";
				$paises=mysqli_query($mysqli, $sentencia);
				if(!$paises || $mysqli->errno){
					die("Error: No se pudo realizar la consulta".$mysqli->error);
				}
				echo "<label for='pais'>País:</label><select id='pais' name='pais'>";
				while($pais=$paises->fetch_assoc()){
					echo "<option value='".$pais['IdPais']."'";
					if(isset($_POST["pais"])&&$_POST["pais"]==$pais['IdPais']){ echo "selected='selected'"; }
					echo ">".$pais['NomPais']."</option>";
				}
				echo "</select><br>";
			?>
			<label for="foto">Foto:</label><input type="file" name="foto"><br><br>
			<?php

				$el_usuario;
				if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
					$usuarios = explode(":",$_COOKIE['usuario']);
					$el_usuario = $usuarios[0];
				}
				else{

					$el_usuario = $_SESSION["user"];

				}

				$sentalbum="select ALBUMES.* from ALBUMES, USUARIOS where ALBUMES.Usuario = USUARIOS.IdUsuario and USUARIOS.NomUsuario='".$el_usuario."';";
				$albumes=mysqli_query($mysqli, $sentalbum);
				if(!$albumes || $mysqli->errno){
					die("Error: No se pudo realizar la consulta".$mysqli->error);
				}
				echo "<label for='album'>Álbum:</label><select id='album' name='album'>";
				while($album=$albumes->fetch_assoc()){
					echo "<option value='".$album['IdAlbum']."'";
					if(isset($_POST["album"])&&$_POST["album"]==$album['IdAlbum']){ echo "selected='selected'"; }
					echo ">".$album['Titulo']."</option>";
				}
				echo "</select><br>";
			?>
			<div class="botonet"><input type="submit" value="Completar registro"></div>
		</form>

</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
