<?php 
$page_title = "TechSolutions - Trabajá con Nosotros";
include 'includes/header.php'; 
?>

<main class="min-vh-100 bg-dark text-white py-5">
  <div class="container py-5">
    <div class="row justify-content-center">
      <div class="col-lg-8">
        
        <!-- Mensajes de éxito/error -->
        <?php if (isset($_GET['enviado'])): ?>
          <div class="alert alert-success mb-4">
            <i class="bi bi-check-circle-fill me-2"></i>
            ¡Tu postulación fue enviada con éxito!
          </div>
        <?php endif; ?>

        <?php
        if (!empty($_GET['errores'])):
          $errores = json_decode(urldecode($_GET['errores']), true);
          if (is_array($errores)):
        ?>
            <div class="alert alert-danger mb-4">
              <i class="bi bi-exclamation-triangle-fill me-2"></i>
              <strong>Error en el formulario:</strong>
              <ul class="mb-0 mt-2">
                <?php foreach ($errores as $error): ?>
                  <li><?= htmlspecialchars($error, ENT_QUOTES, 'UTF-8') ?></li>
                <?php endforeach; ?>
              </ul>
            </div>
        <?php
          endif;
        endif;
        ?>

        <!-- Encabezado -->
        <div class="text-center mb-5">
          <h1 class="display-4 text-primary fw-bold mb-3">Trabajá con Nosotros</h1>
          <p class="lead text-light">Si querés formar parte de nuestro equipo, completá el siguiente formulario. ¡Te estamos esperando!</p>
        </div>

        <!-- Formulario -->
        <form action="servidor-php/postular.php" method="POST" enctype="multipart/form-data" class="needs-validation" novalidate>
          <div class="row g-4 mb-4">
            <div class="col-md-6">
              <label for="nombre" class="form-label">Nombre completo</label>
              <input type="text" class="form-control bg-dark-700 border-dark text-white" id="nombre" name="nombre" required>
              <div class="invalid-feedback">
                Por favor ingresa tu nombre completo.
              </div>
            </div>
            
            <div class="col-md-6">
              <label for="email" class="form-label">Email</label>
              <input type="email" class="form-control bg-dark-700 border-dark text-white" id="email" name="email" required>
              <div class="invalid-feedback">
                Por favor ingresa un email válido.
              </div>
            </div>
            
            <div class="col-md-6">
              <label for="telefono" class="form-label">Teléfono</label>
              <input type="tel" class="form-control bg-dark-700 border-dark text-white" id="telefono" name="telefono">
            </div>
            
            <div class="col-md-6">
              <label for="cv" class="form-label">Cargar CV (PDF)</label>
              <input type="file" class="form-control bg-dark-700 border-dark text-white" id="cv" name="cv" accept=".pdf" required>
              <div class="invalid-feedback">
                Por favor adjunta tu CV en formato PDF.
              </div>
            </div>
          </div>
          
          <div class="mb-4">
            <label for="educacion" class="form-label">Educación</label>
            <textarea class="form-control bg-dark-700 border-dark text-white" id="educacion" name="educacion" rows="3" required></textarea>
            <div class="invalid-feedback">
              Por favor describe tu formación académica.
            </div>
          </div>
          
          <div class="mb-4">
            <label for="experiencia" class="form-label">Experiencia laboral</label>
            <textarea class="form-control bg-dark-700 border-dark text-white" id="experiencia" name="experiencia" rows="3" required></textarea>
            <div class="invalid-feedback">
              Por favor detalla tu experiencia profesional.
            </div>
          </div>
          
          <div class="mb-4">
            <label for="proyectos" class="form-label">Proyectos realizados</label>
            <textarea class="form-control bg-dark-700 border-dark text-white" id="proyectos" name="proyectos" rows="3"></textarea>
          </div>
          
          <div class="mb-4">
            <label for="mensaje" class="form-label">Mensaje adicional</label>
            <textarea class="form-control bg-dark-700 border-dark text-white" id="mensaje" name="mensaje" rows="3"></textarea>
          </div>
          
          <div class="text-center mt-5">
            <button type="submit" class="btn btn-primary btn-lg px-4 py-2">
              <i class="bi bi-send-fill me-2"></i> Enviar postulación
            </button>
          </div>
        </form>
      </div>
    </div>
  </div>
</main>

<?php include 'includes/footer.php'; ?>

<!-- Script para validación del formulario -->
<script>
// Ejemplo de validación con Bootstrap
(function() {
  'use strict';
  
  // Obtener todos los formularios a los que queremos aplicar estilos de validación de Bootstrap
  var forms = document.querySelectorAll('.needs-validation');
  
  // Bucle sobre ellos y evitar el envío
  Array.prototype.slice.call(forms)
    .forEach(function(form) {
      form.addEventListener('submit', function(event) {
        if (!form.checkValidity()) {
          event.preventDefault();
          event.stopPropagation();
        }
        
        form.classList.add('was-validated');
      }, false);
    });
})();
</script>