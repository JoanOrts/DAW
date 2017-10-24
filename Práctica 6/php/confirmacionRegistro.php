<?php 
$title="Confirmar registro. Pictures &amp; Images";
require_once("head.php");
require_once("header.php");
?>
		<main>
			<h2>Registro realizado con éxito</h2>
			<p>Sus datos introducidos son los siguientes:</p>
			<section class="confirmacion">
			<table class="tabla">
				<thead>
					<tr>
						<th>Concepto</th>
						<th>Selección</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td><strong>Nombre de usuario:</strong></td>
						<td><?php echo $_POST["usuario"];?></td>
					</tr>
					<tr>
						<td><strong>Contraseña:</strong></td>
						<td><?php echo $_POST["contrasena"];?></td>
					</tr>
					<tr>
						<td><strong>Email:</strong></td>
						<td><?php echo $_POST["email"];?></td>
					</tr>
					<tr>
						<td><strong>Sexo:</strong></td>
						<td><?php echo $_POST["sexo"];?></td>
					</tr>
					<tr>
						<td><strong>Fecha de Nacimiento:</strong></td>
						<td><?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["anyo"];?></td>
					</tr>
					<tr>
						<td><strong>Ciudad:</strong></td>
						<td><?php echo $_POST["ciudad"];?></td>
					</tr>
					<tr>
						<td><strong>País:</strong></td>
						<td><?php echo $_POST["pais"];?></td>
					</tr>
					<tr>
						<td><strong>Foto de Perfil:</strong></td>
						<td><?php echo $_POST["foto"];?></td>
					</tr>
				</tbody>
			</table>
			</section>
			<h3>Coste del álbum</h3>
			<p>El coste total del álbum es de <strong>5.00€</strong></p>

			<p>Gracias por confiar en el servicio de impreso de álbumes de <strong>Pictures &amp; Images</strong>, el álbum lo recibirá la fecha que ha especificado.</p>
		</main>
<?php
require_once("footer.php");
?>
