<?php 
session_start();
require_once("controlAcceso.php");
$title="Resultados búsqueda. Pictures &amp; Images";
require_once("head.php");
if(isset($_SESSION["Estado"])&&$_SESSION["Estado"]=="Autenticado"){
	require_once("headerRegistrado.php");
}
else{
	require_once("header.php");
}
?>	
		<main>
			<h2>Resultados de la búsqueda</h2>
			<figure class="fotografia">
                <a href="DetalleFoto.php?id=1"><img src="../images/foto3.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: <?php echo $_POST["titulo"];?></li>
                    <li>Fecha: <?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["año"];?></li>
                    <li>País: <?php echo $_POST["pais"];?></li>
                </ul>
			</figure><br>
			<figure class="fotografia">
                <a href="DetalleFoto.php?id=2"><img src="../images/foto1.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: <?php echo $_POST["titulo"];?></li>
                    <li>Fecha: <?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["año"];?></li>
                    <li>País: <?php echo $_POST["pais"];?></li>
                </ul>
			</figure><br>
			<figure class="fotografia">
                <a href="DetalleFoto.php?id=3"><img src="../images/foto2.jpg" alt="Imagen" width=400></a>
                <ul>
                    <li>Título: <?php echo $_POST["titulo"];?></li>
                    <li>Fecha: <?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["año"];?></li>
                    <li>País: <?php echo $_POST["pais"];?></li>
                </ul>
			</figure>
		</main>
<?php
require_once("footer.php");
?>
