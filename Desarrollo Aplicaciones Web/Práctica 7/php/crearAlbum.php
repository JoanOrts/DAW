<?php
$title="Crear álbum. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
?>
<main>
    <h2>Formulario creación album</h2>
		<p>Introduce los siguientes datos:</p>
		<form class="formulariobusqueda" method="post">
			<label for="titulo">Título:</label> <input type="text" name="nusuario" id="nusuario" placeholder="Título del album"><br>
			<label for="descripcion">Descripción:</label><textarea name="descripcion" id="descripcion" maxlength="4000" rows="4" cols="50" placeholder="Introduzca una descripción del album"></textarea><br>
			<label for="fecha">Fecha:</label> <input type="date" name="fecha" id="fecha"><br>
			<label for="pais">País:</label> <input type="text" name="pais" id="pais" placeholder="País de residencia"><br>
			<div class="botonet"><input type="submit" value="Completar registro"></div>
		</form>

</main>
<?php
require_once("footer.php");
?>
