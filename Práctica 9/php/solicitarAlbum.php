<?php
session_start();
require_once("comprobarSesion.php");
$title="Solicitar álbum. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php")
?>
		<main>
			<h2>Solicitar álbum</h2>
				<p>Mediante esta opción puedes solicitar la impresión y envío de uno de tus álbumes a todo color y a toda resolución. El precio del álbum
				variará dependiendo del número de páginas que tenga el álbum, de la resolución elgida y de si las fotos están en color o en blanco y negro.
				A continuación le mostraremos nuestras tarifas:</p>
				<table>
					<thead>
						<tr>
							<th>Concepto</th>
							<th>Tarifa</th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td> 5 páginas</td>
							<td>0.10€ por pág.</td>
						</tr>
						<tr>
							<td>Entre 5 y 10 paginas</td>
							<td>0.08€ por pág.</td>
						</tr>
						<tr>
							<td>&#62; 11 páginas</td>
							<td>0.07€ por pág.</td>
						</tr>
						<tr>
							<td>Blanco y negro</td>
							<td>0.05€ por foto</td>
						</tr>
						<tr>
							<td>Color</td>
							<td>0.20€ por foto</td>
						</tr>
						<tr>
							<td>Resolución &#62; 300 dpi</td>
							<td>0.02€ por foto</td>
						</tr>
					</tbody>
				</table>
			<h2>Formulario de solicitud</h2>
			<p>Rellene el formulario. Los campos con (*) son obligatorios</p>
				<form action="confirmacionAlbum.php" class="albumsolicitar" method="post">
					<label for="nombrecompleto">Nombre completo (*):</label><input type="text" id="nombrecompleto" name="nombrecompleto" placeholder="Nombre completo" maxlength="200" required><br>
					<label for="tituloalbum">Título del álbum (*):</label><input type="text" id="tituloalbum" name="tituloalbum" placeholder="Título del álbum" maxlength="200"><br>
					<label for="textoadicional">Texto adicional:</label><textarea name="textoadicional" id="textoadicional" rows="10" cols="60" maxlength="400"></textarea><br>
					<label for="email">Correo electrónico (*):</label><input type="email" id="email" name="correoelectronico" placeholder="Email" maxlength="200"><br>
					<label>Dirección (*):</label>
					<input type="text" name="calle" placeholder="Calle">
					<input type="number" name="numero" placeholder="Número" size="5">
					<input type="number" name="cp" placeholder="CP" size="6">
					<input type="text" name="localidad" placeholder="Localidad">
					<input type="text" name="provincia" placeholder="Provincia"><br>
					<label for="colorportada">Color de portada:</label><input type="color" id="colorportada" name="colorportada"><br>
					<label for="numerocopias">Número de copias (*):</label><input type="number" id="numerocopias" name="numerocopias" min="1" value="1"><br>
					<label for="resolucionfotos">Resolución de las fotos (DPI):</label><input type="number" id="resolucionfotos" name="resolucionfotos" min="150" max="900" step="150" value="150"><br>
					<?php
						$sentencia="select * from ALBUMES a, USUARIOS u where a.Usuario = u.IdUsuario and u.NomUsuario='".$_SESSION["user"]."';";
						$album=mysqli_query($mysqli, $sentencia);
						if(!$album || $mysqli->errno){
							die("Error: No se pudo realizar la consulta".$mysqli->error);
						}
						echo "<label for='album'>Albumes:</label><select id='album' name='album'>";
						while($albu=$album->fetch_assoc()){
							echo "<option value=".$albu['IdAlbum'];
							if(isset($_POST["album"])&&$_POST["album"]==$albu['IdAlbum']){ echo "selected='selected'"; }
							echo ">".$albu['Titulo']."</option>";
						}
						echo "</select>(*)<br>";
						mysqli_free_result($album);
					?><br>
					<label>Fecha de recepción:</label>
						<input type="date" name="fecha" id="fecha"><br>
					<label>Impresión:</label>
					<label for="color">Color<input type="radio" name="color" id="color" value="Color"></label>
					<label for="blancoynegro">Blanco y negro<input type="radio" name="color" id="blancoynegro" value="Blanco y negro"></label><br>

					<div class="botonet"><input type="submit" value="Solicitar" class="botonsubmit"></div>
				</form>
		</main>
		<?php
		mysqli_close($mysqli);
		require_once("footer.php");
		?>
