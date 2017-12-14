<?php
session_start();
require_once("comprobarSesion.php");
$title="Confirmación álbum. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
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
						<td><?php echo $_POST["album"];?></td>
					</tr>
					<tr>
						<td><strong>Fecha de recepción:</strong></td>
						<td><?php echo $_POST["fecha"];?></td>
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
				if($resolucion >= 150){
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
			}

		if(isset($_POST)){
			$sentencia="INSERT INTO SOLICITUDES (Album, Nombre, Titulo, Descripcion, Email, Calle, Numero, CP, Localidad, Provincia, Color, Copias, Resolucion, Fecha, IColor, FRegistro, Coste) values (";
			if(isset($_POST["album"])){
				$sentencia=$sentencia.$_POST["album"];
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["nombrecompleto"])){
				$sentencia=$sentencia.", '".$_POST["nombrecompleto"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["tituloalbum"])){
				$sentencia=$sentencia.", '".$_POST["tituloalbum"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["textoadicional"])){
				$sentencia=$sentencia.", '".$_POST["textoadicional"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["correoelectronico"])){
				$sentencia=$sentencia.", '".$_POST["correoelectronico"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["calle"])){
				$sentencia=$sentencia.", '".$_POST["calle"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["numero"])){
				$sentencia=$sentencia.", '".$_POST["numero"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["cp"])){
				$sentencia=$sentencia.", '".$_POST["cp"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["localidad"])){
				$sentencia=$sentencia.", '".$_POST["localidad"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["provincia"])){
				$sentencia=$sentencia.", '".$_POST["provincia"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["colorportada"])){
				$sentencia=$sentencia.", '".$_POST["colorportada"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["numerocopias"])){
				$sentencia=$sentencia.", '".$_POST["numerocopias"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["resolucionfotos"])){
				$sentencia=$sentencia.", '".$_POST["resolucionfotos"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["fecha"])){
				$sentencia=$sentencia.", '".$_POST["fecha"]."'";
			}
			else{
				$sentencia=$sentencia.", ";
			}
			if(isset($_POST["color"])){
				$color=1;
				$bn = 0;
				if($_POST["color"]=="Blanco y negro"){
					$sentencia=$sentencia.", '".$bn."'";
				}
				else{
					$sentencia=$sentencia.", '".$color."'";
				}			
			}
			else{
				$sentencia=$sentencia.", ";
			}
			$precio = calcular_precio();
			$sentencia=$sentencia.", UTC_TIMESTAMP, ".$precio.");";
			mysqli_query($mysqli, $sentencia);
		}

			?>
			<p>El coste total del álbum es de <strong><?php echo calcular_precio();?></strong></p>

			<p>Gracias por confiar en el servicio de impreso de álbumes de <strong>Pictures &amp; Images</strong>, el álbum lo recibirá la fecha que ha especificado.</p>
		</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
