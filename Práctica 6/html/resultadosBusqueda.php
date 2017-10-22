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
                    <li>Título: <?php echo $_POST["titulo"];?></li>
                    <li>Fecha: <?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["año"];?></li>
                    <li>País: <?php echo $_POST["pais"];?></li>
                </ul>
			</figure><br>
			<figure class="fotografia">
                <a href="DetalleFoto.php"><img src="../images/foto1.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: <?php echo $_POST["titulo"];?></li>
                    <li>Fecha: <?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["año"];?></li>
                    <li>País: <?php echo $_POST["pais"];?></li>
                </ul>
			</figure><br>
			<figure class="fotografia">
                <a href="DetalleFoto.php"><img src="../images/foto2.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: <?php echo $_POST["titulo"];?></li>
                    <li>Fecha: <?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["año"];?></li>
                    <li>País: <?php echo $_POST["pais"];?></li>
                </ul>
			</figure>
		</main>
		<?php include("footer.php"); ?>
	</body>
</html>
