<?php
session_start();
require_once("acceso.php");
require_once("controlAcceso.php");
$title="Búsqueda. Pictures &amp; Images";
require_once("head.php");
if(isset($_SESSION["Estado"])&&$_SESSION["Estado"]=="Autenticado"){
	require_once("headerRegistrado.php");
}
else{
	require_once("header.php");
}
require_once("conexionbd.php");

?>

		<main>
			<h2>Búsqueda</h2>
				<form action="resultadosBusqueda.php" class="formulariobusqueda" method="post">
					<label for="titulo">Título:</label><input type="text" id="titulo" name="titulo" placeholder="Título de la foto"><br><br>
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
					?><br>
					<label for="fecha">Fecha:</label> <input type="date" name="fecha" id="fecha"><br><br>
					<div class="botonet"><input type="submit" value="Buscar"></div>
				</form>
		</main>
		<?php
		mysqli_close($mysqli);
		require_once("footer.php");
		?>
