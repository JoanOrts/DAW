<?php 
session_start();
require_once("comprobarSesion.php");
$title="Detalle Foto. Pictures &amp; Images";
$user = $_GET["user"];
require_once("head.php");
require_once("headerRegistrado.php");
?>

	<main>
		<h2>Perfil del usuario <strong><?php echo $_GET["user"]; ?></strong></h2>

			<section class="fotografia">
				<figure class="avatarusuario"><img src="../images/usuario.png" alt="Foto_perfil" width=300></figure>
				<ul>
		
				    <li>Usuario desde: 07/09/2017</li>
				    <li>País: España</li>
				    <li>Mensaje: Hola amigos soy <?php echo $_GET["user"]; ?></li>
				    <li>Mis albumes: <a href="">7 albumes</a></li>
				</ul>
			</section>
	</main>

<?php
require_once("footer.php");
?>
