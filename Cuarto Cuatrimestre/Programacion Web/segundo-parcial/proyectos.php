<?php 
$page_title = "TechSolutions - Proyectos Destacados";
include 'includes/header.php'; 
?>

<main class="min-vh-100 bg-dark text-white py-5">
  <div class="container py-5">
    <div class="text-center mb-5">
      <h1 class="display-3 text-primary fw-bold mb-3">Nuestros Proyectos</h1>
      <p class="lead text-dark">Conocé algunos de los proyectos que hemos desarrollado para nuestros clientes</p>
    </div>

    <div class="row g-4">
      <!-- Proyecto 1 -->
      <div class="col-lg-4 col-md-6">
        <div class="card bg-dark-800 border-0 h-100 project-card">
          <div class="card-img-top bg-dark-700 p-4 text-center">
            <i class="bi bi-cart4 text-primary display-4"></i>
          </div>
          <div class="card-body">
            <h3 class="h4 mb-3">Plataforma de E-commerce</h3>
            <p class="text-dark mb-4">Solución completa para retail con integración de pagos, gestión de inventario y analytics.</p>
            <div class="d-flex flex-wrap gap-2">
              <span class="badge bg-primary bg-opacity-10 text-primary">React</span>
              <span class="badge bg-primary bg-opacity-10 text-primary">Node.js</span>
              <span class="badge bg-primary bg-opacity-10 text-primary">MongoDB</span>
            </div>
          </div>
          <div class="card-footer bg-transparent border-0 pt-0 pb-4">
            <a href="#" class="btn btn-sm btn-outline-primary">Ver caso de estudio →</a>
          </div>
        </div>
      </div>

      <!-- Proyecto 2 -->
      <div class="col-lg-4 col-md-6">
        <div class="card bg-dark-800 border-0 h-100 project-card">
          <div class="card-img-top bg-dark-700 p-4 text-center">
            <i class="bi bi-hospital text-primary display-4"></i>
          </div>
          <div class="card-body">
            <h3 class="h4 mb-3">Sistema de Gestión para Clínicas</h3>
            <p class="text-dark mb-4">Software médico con historias clínicas digitales, agenda de turnos y facturación.</p>
            <div class="d-flex flex-wrap gap-2">
              <span class="badge bg-primary bg-opacity-10 text-primary">Angular</span>
              <span class="badge bg-primary bg-opacity-10 text-primary">.NET Core</span>
              <span class="badge bg-primary bg-opacity-10 text-primary">SQL Server</span>
            </div>
          </div>
          <div class="card-footer bg-transparent border-0 pt-0 pb-4">
            <a href="#" class="btn btn-sm btn-outline-primary">Ver caso de estudio →</a>
          </div>
        </div>
      </div>

      <!-- Proyecto 3 -->
      <div class="col-lg-4 col-md-6">
        <div class="card bg-dark-800 border-0 h-100 project-card">
          <div class="card-img-top bg-dark-700 p-4 text-center">
            <i class="bi bi-phone text-primary display-4"></i>
          </div>
          <div class="card-body">
            <h3 class="h4 mb-3">App para Reservas de Restaurantes</h3>
            <p class="mb-4">Aplicación móvil con geolocalización, sistema de reseñas y pagos integrados.</p>
            <div class="d-flex flex-wrap gap-2">
              <span class="badge bg-primary bg-opacity-10 text-primary">Flutter</span>
              <span class="badge bg-primary bg-opacity-10 text-primary">Firebase</span>
              <span class="badge bg-primary bg-opacity-10 text-primary">Stripe</span>
            </div>
          </div>
          <div class="card-footer bg-transparent border-0 pt-0 pb-4">
            <a href="#" class="btn btn-sm btn-outline-primary">Ver caso de estudio →</a>
          </div>
        </div>
      </div>
    </div>

    <div class="text-center mt-5 pt-3">
      <a href="#contacto" class="btn btn-primary px-4 py-2">
        <i class="bi bi-chat-left-text me-2"></i> ¿Querés un proyecto similar?
      </a>
    </div>
  </div>
</main>

<?php include 'includes/footer.php'; ?>