	<?php
require_once("conexionbd.php");
$sentencia = "SELECT * FROM FOTOS ORDER BY FRegistro DESC LIMIT 6";
$fotos = mysqli_query($mysqli, $sentencia);
if(!$fotos || $mysqli->errno){
	die("Error: No se pudo realizar la consulta".$mysqli->error);
}


?>
		<main>
			<h2>Últimas fotos</h2>
			<section class="seccionfotos">
				<?php
					while($foto=$fotos->fetch_assoc()){
						$date=new DateTime($foto['Fecha']);
						$fecha = $date->format('d-m-Y');
						
						$sentpais= "select * from PAISES p where IdPais=".$foto['Pais'];
						$paises=mysqli_query($mysqli, $sentpais);
						if(!$paises || $mysqli->errno){
							die("Error: No se pudo realizar la consulta".$mysqli->error);
						}
						$pais=$paises->fetch_assoc();
							echo "<a href='DetalleFoto.php?id=".$foto['IdFoto']."'>";
							echo "<img src='".$foto['Fichero']."' alt='".$foto['Titulo']."' title='".$foto['Titulo']." | ".$fecha. " | ".$pais['NomPais']."' width=400>";
							if(isset($_SESSION["Estado"])&&$_SESSION["Estado"]=="Autenticado"){
								echo "</a>";
							}

					/*
						echo "<img src='".$foto['Fichero']."' alt='".$foto['Titulo']."' title='".$foto['Titulo']." | ".$fecha. " | ".$pais['NomPais']."' width=400></a>";
							
						echo "<ul>
								<li>Título:".$foto['Titulo']."</li>
								<li>Fecha:".$foto['Fecha']."</li>
								<li>País:".$foto['Pais']."</li>
						</ul>"; 

					*/
					
						
					
					}
					

				?>
			<section>
		</main>
