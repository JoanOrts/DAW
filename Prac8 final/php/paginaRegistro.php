<?php 
session_start();
require_once("acceso.php");
require_once("controlAcceso.php");
$title="Búsqueda. Pictures &amp; Images";
require_once("head.php");
require_once("header.php");
require_once("conexionbd.php");
?>	
	<main>
		<h2>Regístrate</h2>

		<form action="confirmacionRegistro.php" class="formularioregistro" method="post">
			<label for="rusuario">Nombre de usuario:</label><input type="text" id="rusuario" name="usuario" placeholder="Nombre de Usuario"><br><br>
			<label for="rcontraseña">Contraseña:</label><input type="text" id="rcontraseña" name="contrasena" placeholder="Contraseña"><br><br>
			<label for="repetircontraseña">Repetir contraseña:</label><input type="text" id="repetircontraseña" name="rcontrasena" placeholder="Contraseña"><br><br>
			<label for="email">Email:</label><input type="text" id="email" name="email" placeholder="Email"><br><br>
			<label>Sexo:</label>
			<label for="hombre">Hombre<input type="radio" name="sexo" id="hombre" value="Hombre"></label>
		    <label for="mujer">Mujer<input type="radio" name="sexo" id="mujer" value="Mujer"></label><br><br>
			<label>Fecha de nacimiento:</label>
				<input type="number" name="dia" size="2" maxlength="2" placeholder="Dia"/>/<input type="number" name="mes" size="2" maxlength="2" placeholder="Mes"/>/<input type="number" name="anyo" size="4" maxlength="4" placeholder="Año"/><br><br>
			<label for="ciudad">Ciudad:</label><input type="text" id="ciudad" name="ciudad" placeholder="Ciudad"><br><br>
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
			?><br><br>
			<label for="foto">Foto:</label><input type="file" name="foto"><br><br>
			<div class="botonet"><input type="submit" class="botonsubmit" value="¡Regístrate!" onclick = "location='PaginaPrincipal.php'"></div>
		</form>

	</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
