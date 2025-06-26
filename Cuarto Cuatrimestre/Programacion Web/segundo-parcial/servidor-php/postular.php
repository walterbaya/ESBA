<?php
include 'config.php';

// Obtener las variables del formulario
$nombre = $_POST['nombre'] ?? '';
$email = $_POST['email'] ?? '';
$telefono = $_POST['telefono'] ?? '';
$educacion = $_POST['educacion'] ?? '';
$experiencia = $_POST['experiencia'] ?? '';
$proyectos = $_POST['proyectos'] ?? '';
$mensaje = $_POST['mensaje'] ?? '';

// Validación de campos requeridos
$campos = [
  'nombre' => 'El nombre es obligatorio.',
  'email' => 'El email es obligatorio.',
  'educacion' => 'La educación es obligatoria.',
  'experiencia' => 'La experiencia es obligatoria.'
];

$errores = [];

foreach ($campos as $campo => $mensajeError) {
  $$campo = trim($_POST[$campo] ?? '');
  if ($$campo === '') {
    $errores[] = $mensajeError;
  }
}

// Validación del CV (PDF)
$cvNombre = null;
$cvContenido = null;

if (isset($_FILES['cv']) && $_FILES['cv']['error'] === 0) {
  $ext = strtolower(pathinfo($_FILES['cv']['name'], PATHINFO_EXTENSION));
  
  if ($ext !== 'pdf') {
    $errores[] = 'El archivo debe tener la extensión .pdf.';
  } else {
    $finfo = new finfo(FILEINFO_MIME_TYPE);
    $mime = $finfo->file($_FILES['cv']['tmp_name']);
    
    if ($mime !== 'application/pdf') {
      $errores[] = 'El archivo no es un PDF válido.';
    } else {
      $cvNombre = $_FILES['cv']['name'];
      $cvContenido = file_get_contents($_FILES['cv']['tmp_name']);
    }
  }
} else {
  $errores[] = 'Debe adjuntar su CV.';
}

// Si hay errores, redirigir
if (!empty($errores)) {
  $param = urlencode(json_encode($errores));
  header("Location: /trabajá-con-nosotros.php?errores={$param}");
  exit;
}

// Conexión a la base de datos y guardado
try {
  $conn = new PDO("mysql:host=".DB_HOST.";dbname=".DB_NAME, DB_USER, DB_PASS);
  $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

  // Preparar la consulta SQL
  $stmt = $conn->prepare("INSERT INTO postulaciones 
    (nombre, email, telefono, educacion, experiencia, proyectos, mensaje, cv_nombre, cv_contenido, fecha_postulacion) 
    VALUES (:nombre, :email, :telefono, :educacion, :experiencia, :proyectos, :mensaje, :cv_nombre, :cv_contenido, NOW())");

  // Bind de parámetros
  $stmt->bindParam(':nombre', $nombre);
  $stmt->bindParam(':email', $email);
  $stmt->bindParam(':telefono', $telefono);
  $stmt->bindParam(':educacion', $educacion);
  $stmt->bindParam(':experiencia', $experiencia);
  $stmt->bindParam(':proyectos', $proyectos);
  $stmt->bindParam(':mensaje', $mensaje);
  $stmt->bindParam(':cv_nombre', $cvNombre);
  $stmt->bindParam(':cv_contenido', $cvContenido, PDO::PARAM_LOB);

  // Ejecutar la consulta
  $stmt->execute();

  // Redirigir a la página de éxito
  header("Location: /trabajá-con-nosotros.php?enviado=1");
  exit;

} catch(PDOException $e) {
  // En caso de error en la base de datos
  $errores[] = "Error al procesar la postulación. Por favor intente nuevamente.";
  error_log("Error en postulación: " . $e->getMessage());
  $param = urlencode(json_encode($errores));
  header("Location: /trabajá-con-nosotros.php?errores={$param}");
  exit;
}