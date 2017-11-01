	<body>	
		<header>
			<div class="cabeceraizquierda"><a href="index.php"><img src="../images/logo.png" alt="Logo" width=170></a></div>
			<div class="cabeceraderecha">
				<a href="usuarioRegistrado.php"><?php echo $user; ?></a>
				<a href="usuarioRegistrado.php"><img src="../images/usuario.png" alt="icono usuario" width=40></a><br><br>
				<a href="index.php?salir">Salir</a>
				
				<?php if(isset($_COOKIE['usuario'])&&isset($_COOKIE['date'])){
					$usuarios = explode(":",$_COOKIE['usuario']);
					echo "Hola ".$usuarios[0];
					}
				?>

				<nav class="enlacescabecera"><a href="busqueda.php"><em>Búsqueda avanzada</em></a></nav>
			</div>
		</header>
