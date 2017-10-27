<?php 
$title="Búsqueda. Pictures &amp; Images";
require_once("head.php");
require_once("header.php");
?>	

	
		<main>
			<h2>Búsqueda</h2>
				<form action="resultadosBusqueda.php" class="formulariobusqueda" method="post">
					<label for="titulo">Título:</label><input type="text" id="titulo" name="titulo" placeholder="Título de la foto"><br><br>
					<label for="fecha">Fecha entre:</label><input type="number" id="fecha" name="dia" size="2" maxlength="2" placeholder="Dia"/>/<input type="number" name="mes" size="2" maxlength="2" placeholder="Mes"/>/<input type="number" name="año" size="4" maxlength="4" placeholder="Año"/>&nbsp;&nbsp;&nbsp;y&nbsp;&nbsp;&nbsp;<input type="number" name="diados" size="2" maxlength="2" placeholder="Dia"/>/<input type="number" name="mesdos" size="2" maxlength="2" placeholder="Mes"/>/<input type="number" name="añodos" size="4" maxlength="4" placeholder="Año"/><br><br>
					<label for="pais">País:</label><input type="text" id="pais" name="pais" placeholder="País"><br><br><br>
					<div class="botonet"><input type="submit" value="Buscar"></div>
				</form>
		</main>
<?php
require_once("footer.php");
?>
