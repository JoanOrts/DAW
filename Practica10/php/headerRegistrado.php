<header>
			<div class="cabeceraizquierda"><a href="index.php"><img src="../images/logo.png" alt="Logo" width=170></a></div>
			<div class="cabeceraderecha">


				<?php 
					require_once("conexionbd.php");
					$el_user;
					if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
					$usuarios = explode(":",$_COOKIE['usuario']);
					echo 'Saludos, <a href="usuarioRegistrado.php">'.$usuarios[0];
					echo "</a>";

					$sentencia = "select * from USUARIOS where NomUsuario like '".$usuarios[0]."'";
					$usuarios = mysqli_query($mysqli, $sentencia);
					$user = $usuarios->fetch_assoc();
					$el_user = $user;
					}
					else{
						echo '<a href="usuarioRegistrado.php">';
						echo $_SESSION["user"];
						echo "</a>";
						$sentencia = "select * from USUARIOS where NomUsuario like '".$_SESSION["user"]."'";
						$usuarios = mysqli_query($mysqli, $sentencia);
						$user = $usuarios->fetch_assoc();
						$el_user = $user;
					}
				
				echo '<a href="usuarioRegistrado.php"><img src="'.$el_user["Foto"].'" alt="icono usuario" width=40></a><br><br>
				<a href="index.php?salir">Salir</a>  |
				<nav class="enlacescabecera"><a href="busqueda.php">Búsqueda avanzada</a></nav>';
						
				?>
			</div>
</header>
