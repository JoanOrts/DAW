<?php
session_start();
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
				<p><a href="">Mis datos</a></p>
				<p><a href="">Darme de baja</a></p>
				<p><a href="">Mis álbumes</a></p>
				<p><a href="crearAlbum.php">Crear álbum</a></p>
				<p><a href="solicitarAlbum.php">Solicitar álbum</a></p>
				<p><a href="index.php?salir">Salir</a></p>
			</section>
		</main>
<?php
require_once("footer.php");
?>
