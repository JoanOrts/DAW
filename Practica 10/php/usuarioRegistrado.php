<?php
session_start();
require_once("comprobarSesion.php");
$title="Perfil. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
?>
		<main>
			<h2>Bienvenido a Pictures &amp; Images, <strong>

				<?php if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
					$usuarios = explode(":",$_COOKIE['usuario']);
					echo $usuarios[0];
					}
					else{

						echo $_SESSION["user"];

					}
				?>

				</strong></h2>
			<section class="datosusuario">
				<p><a href="misDatos.php">Mis datos</a></p>
				<p><a href="darmeBaja.php">Darme de baja</a></p>
				<p><a href="misAlbumes.php">Mis álbumes</a></p>
				<p><a href="anyadirFoto.php">Añadir Foto a Álbum</a></p>
				<p><a href="crearAlbum.php">Crear álbum</a></p>
				<p><a href="solicitarAlbum.php">Solicitar álbum</a></p>
				<p><a href="index.php?salir">Salir</a></p>
			</section>
		</main>
<?php
require_once("footer.php");
?>
