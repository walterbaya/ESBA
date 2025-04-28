<?php include 'includes/header.php'; ?>
<main class="min-h-screen bg-black text-white font-mono py-10 px-4">
  <h1 class="text-3xl text-blue-400 font-bold mb-4">Trabajá con Nosotros</h1>
  <p class="text-gray-300 mb-6">Si querés formar parte de nuestro equipo, completá el siguiente formulario. ¡Te estamos esperando!</p>

  <?php if (isset($_GET['enviado'])): ?>
    <div class="bg-green-700 text-white p-4 rounded mb-6">¡Tu postulación fue enviada con éxito!</div>
  <?php endif; ?>

  <form action="includes/postular.php" method="POST" enctype="multipart/form-data" class="max-w-xl mx-auto space-y-4">
    <div>
      <label for="nombre" class="block mb-1">Nombre completo</label>
      <input type="text" name="nombre" id="nombre" required>
    </div>
    <div>
      <label for="email" class="block mb-1">Email</label>
      <input type="email" name="email" id="email" required>
    </div>
    <div>
      <label for="telefono" class="block mb-1">Teléfono</label>
      <input type="tel" name="telefono" id="telefono">
    </div>
    <div>
      <label for="educacion" class="block mb-1">Educación</label>
      <textarea name="educacion" id="educacion" rows="3"></textarea>
    </div>
    <div>
      <label for="experiencia" class="block mb-1">Experiencia laboral</label>
      <textarea name="experiencia" id="experiencia" rows="3"></textarea>
    </div>
    <div>
      <label for="proyectos" class="block mb-1">Proyectos realizados</label>
      <textarea name="proyectos" id="proyectos" rows="3"></textarea>
    </div>
    <div>
      <label for="mensaje" class="block mb-1">Mensaje adicional</label>
      <textarea name="mensaje" id="mensaje" rows="3"></textarea>
    </div>
    <div>
      <label for="cv" class="block mb-1">Cargar CV (PDF o Word)</label>
      <input type="file" name="cv" id="cv" accept=".pdf,.doc,.docx" required>
    </div>
    <button type="submit" class="bg-blue-500 text-white px-4 py-2 rounded hover:bg-blue-600">Enviar postulación</button>
  </form>
</main>
<?php include 'includes/footer.php'; ?>