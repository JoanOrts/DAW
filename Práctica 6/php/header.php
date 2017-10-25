	<body>
		<header>
			<div class="cabeceraizquierda"><a href="index.php"><img src="../images/logo.png" alt="Logo" width=170></a></div>
			<div class="cabeceraderecha">
				<form action="controlAcceso.php" method="post" class="formularioacceso">
				 <label for="usuario">Usuario:</label><input type="text" id="usuario" name="usuario" required><br>
				 <label for="contraseña">Contraseña:</label><input type="password" id="contraseña" name="contrasena" required><br>
				 <input type="submit" value="Entrar" id="entrar">
				</form>
				<?php
					if(isset($_GET["error"])){
						echo "<p class='mensaje_error'>Nombre de cuenta o contraseña incorrectos</p>";
					}
				?>
				<nav class="enlacescabecera">¿No estás registrado?&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="paginaRegistro.php"><em>Regístrate</em></a>&nbsp;|&nbsp;<a href="busqueda.php"><em>Búsqueda avanzada</em></a><nav>
			</div>
		</header>
