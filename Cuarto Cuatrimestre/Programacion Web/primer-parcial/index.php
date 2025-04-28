<?php 
$page_title = "TechSolutions - Desarrollo de Software Profesional";
include 'includes/header.php'; 
?>

<main class="main-content">
    <!-- Hero Section -->
    <section class="hero bg-dark-900">
        <div class="container">
            <div class="hero-grid">
                <div class="hero-content">
                    <h1 class="hero-title">
                        <span class="text-gradient">Software</span> que impulsa<br>
                        <span class="text-outline">el futuro digital</span>
                    </h1>
                    <p class="hero-subtitle">Soluciones empresariales escalables y arquitecturas de alto rendimiento</p>
                    <div class="cta-group">
                        <a href="#contact" class="cta-btn primary">Consulta técnica</a>
                        <a href="#cases" class="cta-btn secondary">Casos de estudio →</a>
                    </div>
                </div>
                <div class="hero-code">
                    <pre><code class="language-javascript">// Sistema de autenticación empresarial
const authSystem = new EnterpriseAuth({
  security: 'OAuth2.0 + MFA',
  scalability: 'Cluster Kubernetes',
  monitoring: 'Real-time Analytics',
  compliance: ['GDPR', 'HIPAA', 'SOC2']
});</code></pre>
                </div>
            </div>
        </div>
    </section>

    <!-- Tech Stack -->
    <section class="tech-stack bg-dark-800">
        <div class="container">
            <h2 class="section-title">Arquitecturas Modernas</h2>
            <div class="stack-grid">
                <div class="stack-card">
                    <div class="stack-icon">λ</div>
                    <h3>Serverless Computing</h3>
                    <p>Arquitecturas FaaS con AWS Lambda y Azure Functions</p>
                </div>
                <div class="stack-card">
                    <div class="stack-icon"><img src="microservices-icon.svg" alt="Microservices"></div>
                    <h3>Microservicios</h3>
                    <p>Sistemas distribuidos con Docker y Kubernetes</p>
                </div>
                <div class="stack-card">
                    <div class="stack-icon"><img src="ai-chip.svg" alt="AI"></div>
                    <h3>AI Integrada</h3>
                    <p>Modelos MLops en producción con TensorFlow Serving</p>
                </div>
            </div>
        </div>
    </section>

    <!-- Code Example -->
    <section class="code-sample bg-dark-900">
        <div class="container">
            <div class="code-columns">
                <div class="code-editor">
                    <div class="editor-header">
                        <span class="red"></span>
                        <span class="yellow"></span>
                        <span class="green"></span>
                    </div>
                    <pre><code class="language-python">@distributed_task
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
                <div class="code-description">
                    <h2 class="section-title">Ingeniería de<br> Alto Nivel</h2>
                    <ul class="tech-list">
                        <li>Patrón CQRS con Event Sourcing</li>
                        <li>Encriptación AES-256 + HSMs</li>
                        <li>Logging distribuido (ELK Stack)</li>
                        <li>Transacciones atómicas ACID</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>

    <!-- Enterprise Features -->
    <section class="enterprise-features">
        <div class="container">
            <div class="feature-grid">
                <div class="feature-card">
                    <h3>01.</h3>
                    <h4>CI/CD Automatizado</h4>
                    <p>Pipelines con GitOps y ArgoCD</p>
                    <div class="feature-tech">
                        <span>GitLab</span>
                        <span>Jenkins</span>
                        <span>Tekton</span>
                    </div>
                </div>
                <!-- Repetir más tarjetas -->
            </div>
        </div>
    </section>
</main>

<?php include 'includes/footer.php'; ?>