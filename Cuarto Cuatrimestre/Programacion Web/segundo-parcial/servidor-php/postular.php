<?php

//aca incluimas el archivo de configuracion que creamos a parte para guardar por ejemplo el UPLOAD_DIR, que es la direccion donde se va a cargar el pdf
//ya que no estamos trabajando con bases de datos lo guardamos en una carpeta que esta indicada en UPLOAD_DIR
include 'config.php';

  //obtenemos las variables
  $nombre = $_POST['nombre'] ?? '';
  $email = $_POST['email'] ?? '';
  $telefono = $_POST['telefono'] ?? '';
  $educacion = $_POST['educacion'] ?? '';
  $experiencia = $_POST['experiencia'] ?? '';
  $proyectos = $_POST['proyectos'] ?? '';
  $mensaje = $_POST['mensaje'] ?? '';


  //_FILES seria una variable donde se guardan los archivos que se mandaron por medio del formulario
  //en este caso el isset lo que hace se fijarse que este seteado y que no contenga ['error'],
  
  if (isset($_FILES['cv']) && $_FILES['cv']['error'] === 0) {
    //creamos el $cvPath que es la direccion donde guardaremos el cv enviado
    $cvPath = UPLOAD_DIR . basename($_FILES['cv']['name']);
    //movemos el archivo a esa direccion
    move_uploaded_file($_FILES['cv']['tmp_name'], $cvPath);
  }
    
    //con esto nos redirigimos al header y enviado=1 lo que hace es avisar que efectivamente el archivo fue recibido
    header('Location: /trabajá-con-nosotros.php?enviado=1');
  
  exit;

?>