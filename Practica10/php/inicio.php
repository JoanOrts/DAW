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
							echo "<img src='".$foto['Fichero']."' alt='".$foto['Titulo']."' title='".$foto['Titulo']." | ".$fecha. " | ".$pais['NomPais']."' width=400></a>";
							

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

				<h2>Foto Valorada</h2>
				<?php
				if(($fichero = file("valorada.txt"))==false){
					die("No se ha podido abrir el fichero");
				}
				else{
					$lineas = array();
					foreach($fichero as $fila){
					 $split = explode("_", $fila);
					 if(count($split) < 3){
						die("Split erroneo");
					 }
					 $lineas[] =array("idFoto"=> $split[0],"nombreCritico"=> $split[1],"motivo"=> $split[2], "valoracion"=>$split[3]);
					}
					$clave = rand(0,count($fichero)-1);
					$ID = $lineas[$clave]["idFoto"];
					$critico =$lineas[$clave]["nombreCritico"];
					$motivo =$lineas[$clave]["motivo"];
					$estrellas = $lineas[$clave]["valoracion"];
					$sentencia2 = "SELECT * FROM FOTOS WHERE idFoto = $ID";
					$aleatorio = mysqli_query($mysqli, $sentencia2);
					if($aleatorio){
						if($aleatorio->num_rows >0){
							$res_aleatorio=$aleatorio->fetch_assoc();
							$date=new DateTime($res_aleatorio['Fecha']);
							$fecha = $date->format('d-m-Y');
						
							$sentpais= "select * from PAISES p where IdPais=".$res_aleatorio['Pais'];
							$paises=mysqli_query($mysqli, $sentpais);
							if(!$paises || $mysqli->errno){
								die("Error: No se pudo realizar la consulta".$mysqli->error);
							}
							$pais=$paises->fetch_assoc();
							echo "<figure class='fotografia-aleatoria'><a href='DetalleFoto.php?id=".$res_aleatorio['IdFoto']."'><img src='".$res_aleatorio['Fichero']."' alt='".$res_aleatorio['Titulo']."' title='".$res_aleatorio['Titulo']." | ".$fecha. " | ".$pais['NomPais']."' title='".$res_aleatorio['Titulo']." '></a>";
							echo "<h3><p>$critico</p></h3><p>$motivo</p>
								<p><img src='../images/".$estrellas.".png' alt='".$estrellas." estrellas' title='".$estrellas." estrellas' width=200></p></figure>";
						}
						else{echo"no se ha encontrado foto";}
					}
					else{echo"no se ha encontrado foto $ID";}
				}
				mysqli_close($mysqli); 	
				?>
			<section>
		</main>
