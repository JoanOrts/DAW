<?php
$usuario = $_POST["usuario"];
$contrasenya = $_POST["contrasena"];
$usu1 = "joan7";
$con1 = "dawmola";
$usu2 = "carlos7";
$con2 = "jajaja";
$usu3 = "sergio7";
$con3 = "teneisun10";
if($usuario == $usu1 && $contrasenya == $con1){
  header("Location: http://localhost/DAW/php/usuarioRegistrado.php?user=$usu1");
}
elseif($usuario == $usu2 && $contrasenya == $con2){
  header("Location: http://localhost/DAW/php/usuarioRegistrado.php?user=$usu2");
}
elseif($usuario == $usu3 && $contrasenya == $con3){
  header("Location: http://localhost/DAW/php/usuarioRegistrado.php?user=$usu3");
}
else{
  header("Location: http://localhost/DAW/php/index.php?error");
}

?>
