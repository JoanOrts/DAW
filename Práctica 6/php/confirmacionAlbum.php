<?php
$title="Confirmación álbum. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
?>
		<main>
			<h2>Confirmación álbum</h2>
			<p>Resumen de su pedido:</p>
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
						<td><strong>Nombre completo:</strong></td>
						<td><?php echo $_POST["nombrecompleto"];?></td>
					</tr>
					<tr>
						<td><strong>Título del áblum:</strong></td>
						<td><?php echo $_POST["tituloalbum"];?></td>
					</tr>
					<tr>
						<td><strong>Texto adicional:</strong></td>
						<td><?php echo $_POST["textoadicional"];?></td>
					</tr>
					<tr>
						<td><strong>Correo electrónico:</strong></td>
						<td><?php echo $_POST["correoelectronico"];?></td>
					</tr>
					<tr>
						<td><strong>Dirección:</strong></td>
						<td>C/<?php echo $_POST["calle"];?>, <?php echo $_POST["numero"];?>, <?php echo $_POST["cp"];?>, <?php echo $_POST["localidad"];?>, <?php echo $_POST["provincia"];?></td>
					</tr>
					<tr>
						<td><strong>Color de portada:</strong></td>
						<td><?php echo $_POST["colorportada"];?></td>
					</tr>
					<tr>
						<td><strong>Número de copias:</strong></td>
						<td><?php echo $_POST["numerocopias"];?></td>
					</tr>
					<tr>
						<td><strong>Resolución de las fotos:</strong></td>
						<td><?php echo $_POST["resolucionfotos"];?></td>
					</tr>
					<tr>
						<td><strong>Álbum de PI:</strong></td>
						<td>Álbum 1</td>
					</tr>
					<tr>
						<td><strong>Fecha de recepción:</strong></td>
						<td><?php echo $_POST["dia"];?>/<?php echo $_POST["mes"];?>/<?php echo $_POST["anyo"];?></td>
					</tr>
					<tr>
						<td><strong>Impresión:</strong></td>
						<td><?php echo $_POST["color"];?></td>
					</tr>
				</tbody>
			</table>
			</section>
			<h3>Coste del álbum</h3>
			<?php function calcular_precio(){
    		$numeropag = 12;
				$numerofotos = 4;
				$resolucion = $_POST["resolucionfotos"];
				$color = $_POST["color"];
				if($numeropag < 5){
					$preciopag = 0.10;
				}
				elseif ($numeropag >= 5 && $numeropag <= 10) {
					$preciopag = 0.08;
				}
				else{
					$preciopag = 0.07;
				}
				if($resolucion > 300){
					$precioresolucion = 0.02;
				}
				if($color == "Color"){
					$preciocolor = 0.20;
				}
				else {
					$preciocolor = 0.05;
				}
				$preciototal = $numeropag * $preciopag + $numerofotos * $preciocolor + $numerofotos * $precioresolucion;
				return $preciototal;
			}?>
			<p>El coste total del álbum es de <strong><?php echo calcular_precio();?></strong></p>

			<p>Gracias por confiar en el servicio de impreso de álbumes de <strong>Pictures &amp; Images</strong>, el álbum lo recibirá la fecha que ha especificado.</p>
		</main>
<?php
require_once("footer.php");
?>
