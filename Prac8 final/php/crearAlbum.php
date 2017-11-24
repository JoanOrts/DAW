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
		<p>Introduce los siguientes datos:</p>
		<form class="formulariobusqueda" method="post">
			<label for="titulo">Título:</label> <input type="text" name="nusuario" id="nusuario" placeholder="Título del album"><br>
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
			<div class="botonet"><input type="submit" value="Completar registro"></div>
		</form>

</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
