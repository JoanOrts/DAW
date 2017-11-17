<?php
require_once("conexionbd.php");
$sentencia = "SELECT * FROM fotos ORDER BY FRegistro DESC LIMIT 6";
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
						if(isset($_SESSION["Estado"])&&$_SESSION["Estado"]=="Autenticado"){
							echo "<a href='detallefoto.php?id=".$foto['IdFoto']."'>";
						}
						echo "<img src='".$foto['Fichero']."' alt='".$foto['Titulo']."' width=400>";
						if(isset($_SESSION["Estado"])&&$_SESSION["Estado"]=="Autenticado"){
							echo "</a>";
						}
						/*echo "<ul>
								<li>Título:".$resultado['Titulo']."</li>
								<li>Fecha:".$resultado['Fecha']."</li>
								<li>País:".$pais['NomPais']."</li>
						</ul>";*/
					}
					mysqli_free_result($fotos);

				?>
			<section>
		</main>
