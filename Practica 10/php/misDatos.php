<?php
session_start();
require_once("comprobarSesion.php");
$title="Perfil. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
$sentencia="SELECT * FROM USUARIOS WHERE NomUsuario='".$_SESSION["user"]."';";
$consultadatos=mysqli_query($mysqli, $sentencia);
$misdatos=$consultadatos->fetch_assoc();
?>
<main>
  <h2>Modificar mis datos</h2>

  <form action="confirmacionModificar.php" class="formularioregistro" method="post">
    <label for="rusuario">Nombre de usuario:</label><input type="text" id="rusuario" name="nusuario" placeholder="Nombre de Usuario" <?php echo "value='".$misdatos["NomUsuario"]."'"?>><br><br>
    <label for="rcontraseña">Contraseña:</label><input type="password" id="rcontraseña" name="ncontrasena" placeholder="Contraseña" <?php echo "value='".$misdatos["Clave"]."'"?>><br><br>
    <label for="repetircontraseña">Repetir contraseña:</label><input type="password" id="repetircontraseña" name="rcontrasena" placeholder="Contraseña" <?php echo "value='".$misdatos["Clave"]."'"?>><br><br>
    <label for="email">Email:</label><input type="text" id="email" name="email" placeholder="Email" <?php echo "value='".$misdatos["Email"]."'"?>><br><br>
    <label for="remail">Repetir Email:</label><input type="text" id="remail" name="remail" placeholder="Email" <?php echo "value='".$misdatos["Email"]."'"?>><br><br>
    <label>Sexo:</label>
    <label for="hombre">Hombre<input type="radio" name="sexo" id="hombre" value="Hombre"></label>
    <label for="mujer">Mujer<input type="radio" name="sexo" id="mujer" value="Mujer" checked></label><br><br>
    <label for="fecha">Fecha de Nacimiento:</label> <input type="date" name="fecha" id="fecha" <?php echo "value='".$misdatos["FNacimiento"]."'"?> ><br><br>
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
    <label for="ciudad">Ciudad:</label><input type="text" id="ciudad" name="ciudad" placeholder="Ciudad" <?php echo "value='".$misdatos["Ciudad"]."'"?>><br><br>
    <label for="foto">Foto:</label><input type="file" name="foto"><br><br>
    <div class="botonet"><input type="submit" value="¡Modificar!"></div>
  </form>

</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
