<?php
session_start();
$title="Perfil. Pictures &amp; Images";
$user = $_GET["user"];
require_once("head.php");
require_once("headerRegistrado.php");
?>
		<main>
			<h2>Bienvenido a Pictures &amp; Images, <strong><?php echo $_GET["user"]; ?></strong></h2>
			<section class="datosusuario">
				<p><a href="">Mis datos</a></p>
				<p><a href="">Darme de baja</a></p>
				<p><a href="">Mis álbumes</a></p>
				<p><a href="crearAlbum.php">Crear álbum</a></p>
				<p><a href="solicitarAlbum.php">Solicitar álbum</a></p>
				<p><a href="paginaPrincipal.php">Salir</a></p>
			</section>
		</main>
<?php
require_once("footer.php");
?>
