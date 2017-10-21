<!DOCTYPE html>
<!--Desarrollo de Aplicaciones Web-->
<!-- Carlos, Joan-->
<html lang="es">
	<?php include("head.php"); ?>
	<body>
		<?php include("header.php"); ?>
		<main>
			<h2>Búsqueda</h2>
				<form action="resultadosBusqueda.php" class="formulariobusqueda">
					<label for="titulo">Título:</label><input type="text" id="titulo" name="titulo" placeholder="Título de la foto"><br><br>
					<label for="fecha">Fecha entre:</label><input type="number" id="fecha" name="dia" size="2" maxlength="2" placeholder="Dia"/>/<input type="number" name="mes" size="2" maxlength="2" placeholder="Mes"/>/<input type="number" name="año" size="4" maxlength="4" placeholder="Año"/>&nbsp;&nbsp;&nbsp;y&nbsp;&nbsp;&nbsp;<input type="number" name="dia" size="2" maxlength="2" placeholder="Dia"/>/<input type="number" name="mes" size="2" maxlength="2" placeholder="Mes"/>/<input type="number" name="año" size="4" maxlength="4" placeholder="Año"/><br><br>
					<label for="pais">País:</label><input type="text" id="pais" name="pais" placeholder="País"><br><br><br>
					<div class="botonet"><input type="submit" value="Buscar"></div>
				</form>
		</main>
		<?php include("footer.php"); ?>
	</body>
</html>
