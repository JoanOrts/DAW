<header>
			<div class="cabeceraizquierda"><a href="index.php"><img src="../images/logo.png" alt="Logo" width=170></a></div>
			<div class="cabeceraderecha">


				<?php if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
					$usuarios = explode(":",$_COOKIE['usuario']);
					echo 'Saludos, <a href="usuarioRegistrado.php">'.$usuarios[0];
					echo "</a>";
					}
					else{
						echo '<a href="usuarioRegistrado.php">';
						echo $_SESSION["user"];
						echo "</a>";
					}
				?>
				<a href="usuarioRegistrado.php"><img src="../images/usuario.png" alt="icono usuario" width=40></a><br><br>
				<a href="index.php?salir">Salir</a>  |
				<nav class="enlacescabecera"><a href="busqueda.php">Búsqueda avanzada</a></nav>
			</div>
</header>
