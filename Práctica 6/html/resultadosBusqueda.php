<!DOCTYPE html>
<!--Desarrollo de Aplicaciones Web-->
<!-- Carlos, Joan-->
<html lang="es">
	<?php include("head.php"); ?>
	<body>
		<?php include("header.php"); ?>
		<main>
			<h2>Resultados de la búsqueda</h2>
			<figure class="fotografia">
                <a href="DetalleFoto.php"><img src="../images/foto3.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: Gato</li>
                    <li>Fecha: 28/08/2017</li>
                    <li>País: Seúl</li>
                </ul>
			</figure><br>
			<figure class="fotografia">
                <a href="DetalleFoto.php"><img src="../images/foto1.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: Peces</li>
                    <li>Fecha: 20/10/2016</li>
                    <li>País: España</li>
                </ul>
			</figure><br>
			<figure class="fotografia">
                <a href="DetalleFoto.php"><img src="../images/foto2.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: Carretera</li>
                    <li>Fecha: 07/09/2017</li>
                    <li>País: España</li>
                </ul>
			</figure>
		</main>
		<?php include("footer.php"); ?>
	</body>
</html>
