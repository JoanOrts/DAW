<?php
session_start();
require_once("acceso.php");
require_once("controlAcceso.php");
$title="Confirmar registro. Pictures &amp; Images";
require_once("head.php");
require_once("header.php");
require_once("conexionbd.php");


if(($_POST["nusuario"]==null)||($_POST["ncontrasena"]==null)||($_POST["email"]==null)||($_POST["sexo"]==null)||($_POST["fecha"]==null)){
	header("location: paginaRegistro.php?errornombre");
}
else{
	if(isset($_POST)&&isset($_POST["nusuario"])&&$_POST["nusuario"]!=""){
	$regularnombre="/^([0-9]|[a-z]|[A-Z]){3,15}$/";
	$regularpass="/^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])([0-9]|[a-z]|[A-Z]|_){6,15}$/";
	$nombreusuario=false;
	$passusuario=false;
	$correousuario=false;
	$sexousuario=false;
	$dateusuario=false;
	if(preg_match($regularnombre, $_POST["nusuario"])){
		$nombreusuario=true;
		$sentenciainsercion="INSERT INTO USUARIOS (NomUsuario, Clave, Email, Sexo, FNacimiento, Ciudad, Pais, Foto, FRegistro) values ('".$_POST["nusuario"]."'";
	}
	if(isset($_POST["ncontrasena"])&&isset($_POST["rcontrasena"])&&$_POST["ncontrasena"]!=""&&preg_match($regularpass, $_POST["ncontrasena"])&&strcmp($_POST["ncontrasena"],$_POST["rcontrasena"])==0){
		$passusuario=true;
		$sentenciainsercion=$sentenciainsercion.",'".$_POST["ncontrasena"]."'";
	}
	if(isset($_POST["email"])&&$_POST["email"]!=""&&filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)&&strcmp($_POST["email"], $_POST["remail"])==0){
		$correousuario=true;
		$sentenciainsercion=$sentenciainsercion.",'".$_POST["email"]."'";
	}
	if(isset($_POST["sexo"])&&$_POST["sexo"]!=""){
		if($_POST["sexo"]=="Hombre"){
			$sexousuario=true;
			$sentenciainsercion=$sentenciainsercion.", 0";
		}
		else if($_POST["sexo"]=="Mujer"){
			$sexousuario=true;
			$sentenciainsercion=$sentenciainsercion.", 1";
		}
	}
	if(isset($_POST["fecha"])){
		$dateusuario=true;
		$sentenciainsercion=$sentenciainsercion.",'".$_POST["fecha"]."'";
	}
	if(isset($_POST["ciudad"])&&$_POST["ciudad"]!=""){
		$sentenciainsercion=$sentenciainsercion.",'".$_POST["ciudad"]."'";
	}
	else{
		$sentenciainsercion=$sentenciainsercion.",''";
	}
	if(isset($_POST["pais"])){
		$sentenciainsercion=$sentenciainsercion.",".$_POST["pais"];
	}
	if(isset($_FILES["foto"])){
		/*$sentenciainsercion=$sentenciainsercion.", ''"; //No almacenamos la foto de momento*/
		$nombre_foto = basename($_FILES["foto"]["name"]);
		$ruta ="DAW/images/".$_POST["nusuario"];
		$ruta2="DAW/images/".$_POST["nusuario"]."/".$nombre_foto;
		if(move_uploaded_file($_FILES["foto"]["tmp_name"],$ruta."/".$nombre_foto)){
			$sentenciainsercion=$sentenciainsercion.", '".$ruta2."'";
		}
	}
	else{
		$sentenciainsercion=$sentenciainsercion.", ''";
	}
	$sentenciainsercion=$sentenciainsercion.", UTC_TIMESTAMP);";
	if($nombreusuario==true&&$passusuario==true&&$correousuario==true&&$sexousuario==true&&$dateusuario==true){
		$resultado=mysqli_query($mysqli, $sentenciainsercion);
	}
	else if($nombreusuario==false){
		header("location: paginaRegistro.php?errornombre");
	}
	else if($passusuario==false){
		header("location: paginaRegistro.php?errorpass");

	}
	else if($correousuario==false){
		header("location: paginaRegistro.php?erroremail");

	}
	else if($sexousuario==false){
		header("location: paginaRegistro.php?errorsexual");

	}
	else if($dateusuario==false){
		header("location: paginaRegistro.php?errordate");

	}
}

}
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
						<td><?php echo $_POST["nusuario"];?></td>
					</tr>
					<tr>
						<td><strong>Contraseña:</strong></td>
						<td><?php echo $_POST["ncontrasena"];?></td>
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
						<td><?php echo $_POST["fecha"];?></td>
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
						<td><?php echo $_FILES["foto"]["name"];?></td>
					</tr>
				</tbody>
			</table>
			</section>
		</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
