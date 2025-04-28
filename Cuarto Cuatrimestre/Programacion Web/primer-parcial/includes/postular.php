<?php
include 'config.php';
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
  $nombre = $_POST['nombre'] ?? '';
  $email = $_POST['email'] ?? '';
  $telefono = $_POST['telefono'] ?? '';
  $educacion = $_POST['educacion'] ?? '';
  $experiencia = $_POST['experiencia'] ?? '';
  $proyectos = $_POST['proyectos'] ?? '';
  $mensaje = $_POST['mensaje'] ?? '';

  if (isset($_FILES['cv']) && $_FILES['cv']['error'] === 0) {
    $cvPath = UPLOAD_DIR . basename($_FILES['cv']['name']);
    move_uploaded_file($_FILES['cv']['tmp_name'], $cvPath);
  }

  header('Location: /trabajá-con-nosotros.php?enviado=1');
  exit;
}
?>