<?php
session_start();
require_once("acceso.php");
require_once("controlAcceso.php");
$title="Confirmar registro. Pictures &amp; Images";
require_once("head.php");
require_once("headerRegistrado.php");
require_once("conexionbd.php");
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
		$sentenciainsercion="UPDATE USUARIOS SET NomUsuario='".$_POST["nusuario"]."'";
	}
	if(isset($_POST["ncontrasena"])&&isset($_POST["rcontrasena"])&&$_POST["ncontrasena"]!=""&&preg_match($regularpass, $_POST["ncontrasena"])&&strcmp($_POST["ncontrasena"],$_POST["rcontrasena"])==0){
		$passusuario=true;
		$sentenciainsercion=$sentenciainsercion.", Clave='".$_POST["ncontrasena"]."'";
	}
	if(isset($_POST["email"])&&$_POST["email"]!=""&&filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)&&strcmp($_POST["email"], $_POST["remail"])==0){
		$correousuario=true;
		$sentenciainsercion=$sentenciainsercion.", Email='".$_POST["email"]."'";
	}
	if(isset($_POST["sexo"])&&$_POST["sexo"]!=""){
		if($_POST["sexo"]=="Hombre"){
			$sexousuario=true;
			$sentenciainsercion=$sentenciainsercion.", Sexo=0";
		}
		else if($_POST["sexo"]=="Mujer"){
			$sexousuario=true;
			$sentenciainsercion=$sentenciainsercion.", Sexo=1";
		}
	}
	if(isset($_POST["fecha"])){
		$dateusuario=true;
		$sentenciainsercion=$sentenciainsercion.", FNacimiento='".$_POST["fecha"]."'";
	}
	if(isset($_POST["ciudad"])&&$_POST["ciudad"]!=""){
		$sentenciainsercion=$sentenciainsercion.", Ciudad='".$_POST["ciudad"]."'";
	}
	if(isset($_POST["pais"])){
		$sentenciainsercion=$sentenciainsercion.", Pais=".$_POST["pais"];
	}
	/*if(isset($_POST["foto"])){
		$sentenciainsercion=$sentenciainsercion.","; //No almacenamos la foto de momento
	}*/
	$sentenciainsercion=$sentenciainsercion." WHERE USUARIOS.NomUsuario='".$_SESSION["user"]."';";
	if($nombreusuario==true&&$passusuario==true&&$correousuario==true&&$sexousuario==true&&$dateusuario==true){
		$resultado=mysqli_query($mysqli, $sentenciainsercion);
	}
	else if($nombreusuario==false||$passusuario==false||$correousuario==false||$sexousuario==false||$dateusuario==false){
		header("location: misDatos.php");
	}
}
?>
		<main>
			<h2>Modificación realizada con éxito</h2>
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
						<td><?php echo $_POST["foto"];?></td>
					</tr>
				</tbody>
			</table>
			</section>
		</main>
<?php
mysqli_close($mysqli);
require_once("footer.php");
?>
