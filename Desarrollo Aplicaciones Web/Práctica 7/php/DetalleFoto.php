<?php 
session_start();
$title="Detalle Foto. Pictures &amp; Images";
require_once("head.php");
require_once("header.php");
?>
		<main>
			<h2>Detalles de la foto</h2>
			
			<?php
			if($_GET['id']%2===0){
			?>
			<figure class="fotografia">
				<img src="../images/foto2.jpg" alt="Imagen" width=400>
				<ul>
				    <li>Título: Carretera</li>
				    <li>Fecha: 07/09/2017</li>
				    <li>País: España</li>
				    <li>Álbum: Viaje a Madrid</li>
				    <li>Usuario: <a href="usuarioRegistrado.php?user=sergio7">sergio7</a></li>
				</ul>
			</figure>
			<?php
			}
			else{
			?>
			<figure class="fotografia">
				<img src="../images/foto5.jpg" alt="Imagen" width=400>
				<ul>
				    <li>Título: Tobi</li>
				    <li>Fecha: 21/08/2012</li>
				    <li>País: Finlandia</li>
				    <li>Álbum: El fantástico Tobi</li>
				    <li>Usuario: <a href="usuarioRegistrado.php?user=joan7">joan7</a></li>
				</ul>
			</figure>
			<?php
			}
			?>
		</main>
<?php
require_once("footer.php");
?>
