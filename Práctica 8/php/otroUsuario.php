<?php 
session_start();
require_once("comprobarSesion.php");
$title="Detalle Foto. Pictures &amp; Images";
$user = $_GET["user"];
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
?>

	<main>
		<h2>Perfil del usuario <strong><?php echo $_GET["user"]; ?></strong></h2>
			<?php

			$sentuser = "select * from USUARIOS where NomUsuario = '".$_GET['user']."';";
			$usuarios = mysqli_query($mysqli, $sentuser);
			if(!$usuarios || $mysqli->errno){
				die("Error: No se pudo realizar la consulta".$mysqli->error);
			}
			$usuario=$usuarios->fetch_assoc();
			$sentpais= "select * from PAISES p where IdPais=".$usuario['Pais'];
				$paises=mysqli_query($mysqli, $sentpais);
				if(!$paises || $mysqli->errno){
					die("Error: No se pudo realizar la consulta".$mysqli->error);
				}
				$pais=$paises->fetch_assoc();

			echo "<section class='fotografia'>
				<figure class='avatarusuario'><img src='".$usuario['Foto']."' alt='Foto_perfil' width=300></figure>
				<ul>
		
				    <li>Usuario desde: ".$usuario['FRegistro']."</li>
				    <li>País: ".$pais['NomPais']."</li>
				    <li>Mensaje: Hola amigos soy ".$_GET["user"]."</li>				 
				</ul>
			</section>";

			?>
	</main>

<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
