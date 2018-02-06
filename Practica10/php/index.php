<?php
session_start();
require_once("acceso.php");
require_once("controlAcceso.php");
$title="Pictures &amp; Images";
require("head.php");

if(isset($_SESSION["Estado"])&&$_SESSION["Estado"]=="Autenticado"){
	require_once("headerRegistrado.php");
}
else{
	require_once("header.php");
}

require_once("inicio.php");
require_once("footer.php");
?>
