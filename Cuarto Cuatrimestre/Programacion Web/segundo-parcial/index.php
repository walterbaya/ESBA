<?php 
$page_title = "TechSolutions - Desarrollo de Software Profesional";
include 'includes/header.php'; 
?>

<main class="main-content">
    <!-- Hero Section -->
    <section class="hero bg-dark text-white py-5">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-6 mb-4 mb-lg-0">
                    <h1 class="display-3 fw-bold mb-4">
                        <span class="text-gradient">Software</span> que impulsa<br>
                        <span class="text-outline">el futuro digital</span>
                    </h1>
                    <p class="lead mb-4">Soluciones empresariales escalables y arquitecturas de alto rendimiento</p>
                    <div class="d-flex flex-wrap gap-3">
                        <a href="#contact" class="btn btn-primary btn-lg px-4">Consulta técnica</a>
                        <a href="#cases" class="btn btn-outline-light btn-lg px-4">Casos de estudio <i class="bi bi-arrow-right ms-2"></i></a>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="card bg-dark-800 border-0 p-3">
                        <div class="card-body p-0">
                            <pre class="m-0"><code class="language-javascript">// Sistema de autenticación empresarial
const authSystem = new EnterpriseAuth({
  security: 'OAuth2.0 + MFA',
  scalability: 'Cluster Kubernetes',
  monitoring: 'Real-time Analytics',
  compliance: ['GDPR', 'HIPAA', 'SOC2']
});</code></pre>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Tech Stack -->
    <section class="py-5 bg-dark-800">
        <div class="container">
            <h2 class="text-center mb-5 display-4 fw-bold">Arquitecturas Modernas</h2>
            <div class="row g-4">
                <div class="col-md-4">
                    <div class="card h-100 bg-dark-700 border-0 p-4">
                        <div class="card-body text-center">
                            <div class="display-4 mb-3">λ</div>
                            <h3 class="h4 mb-3">Serverless Computing</h3>
                            <p class="mb-0">Arquitecturas FaaS con AWS Lambda y Azure Functions</p>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card h-100 bg-dark-700 border-0 p-4">
                        <div class="card-body text-center">
                            <img src="microservices-icon.svg" alt="Microservices" class="img-fluid mb-3" style="height: 60px;">
                            <h3 class="h4 mb-3">Microservicios</h3>
                            <p class="mb-0">Sistemas distribuidos con Docker y Kubernetes</p>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card h-100 bg-dark-700 border-0 p-4">
                        <div class="card-body text-center">
                            <img src="ai-chip.svg" alt="AI" class="img-fluid mb-3" style="height: 60px;">
                            <h3 class="h4 mb-3">AI Integrada</h3>
                            <p class="mb-0">Modelos MLops en producción con TensorFlow Serving</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Code Sample -->
    <section class="py-5 bg-dark">
        <div class="container">
            <div class="row g-5 align-items-center">
                <div class="col-lg-6">
                    <div class="card bg-dark-800 border-0">
                        <div class="card-header bg-dark-700 py-3">
                            <span class="d-inline-block rounded-circle bg-danger me-2" style="width: 12px; height: 12px;"></span>
                            <span class="d-inline-block rounded-circle bg-warning me-2" style="width: 12px; height: 12px;"></span>
                            <span class="d-inline-block rounded-circle bg-success" style="width: 12px; height: 12px;"></span>
                        </div>
                        <div class="card-body p-0">
                            <pre class="m-0"><code class="language-python">@distributed_task
def process_transaction(data):
    with db.transaction():
        validated = validate(data)
        encrypted = aes256_encrypt(validated)
        result = blockchain.write(encrypted)
        logger.log_audit({
            'timestamp': utc_now(),
            'hash': result.block_hash,
            'status': 'COMMITTED'
        })
    return result.success</code></pre>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <h2 class="display-4 fw-bold mb-4">Ingeniería de<br> Alto Nivel</h2>
                    <ul class="list-unstyled">
                        <li class="mb-3 d-flex align-items-center">
                            <i class="bi bi-check-circle-fill text-primary me-3"></i>
                            <span>Patrón CQRS con Event Sourcing</span>
                        </li>
                        <li class="mb-3 d-flex align-items-center">
                            <i class="bi bi-check-circle-fill text-primary me-3"></i>
                            <span>Encriptación AES-256 + HSMs</span>
                        </li>
                        <li class="mb-3 d-flex align-items-center">
                            <i class="bi bi-check-circle-fill text-primary me-3"></i>
                            <span>Logging distribuido (ELK Stack)</span>
                        </li>
                        <li class="mb-3 d-flex align-items-center">
                            <i class="bi bi-check-circle-fill text-primary me-3"></i>
                            <span>Transacciones atómicas ACID</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </section>

    <!-- Enterprise Features -->
    <section class="py-5">
        <div class="container">
            <div class="row g-4">
                <div class="col-md-6 col-lg-3">
                    <div class="card h-100 border-0 bg-dark-800 p-4">
                        <div class="card-body">
                            <h3 class="text-gradient">01.</h3>
                            <h4 class="h3 mb-3">CI/CD Automatizado</h4>
                            <p class="mb-4">Pipelines con GitOps y ArgoCD</p>
                            <div class="d-flex flex-wrap gap-2">
                                <span class="badge bg-dark-700 py-2 px-3">GitLab</span>
                                <span class="badge bg-dark-700 py-2 px-3">Jenkins</span>
                                <span class="badge bg-dark-700 py-2 px-3">Tekton</span>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Puedes agregar más tarjetas de características aquí -->
            </div>
        </div>
    </section>
</main>

<?php include 'includes/footer.php'; ?>