<?php 
    $numero1 = $_POST['N1'];
    $numero2 = $_POST['N2'];
    $operacion = $_POST['operacion'];
    $resultado = 0;

    switch ($operacion) {
        case '-':
            $resultado = $numero1 - $numero2;
            break;

        case 'x':
            $resultado = $numero1 * $numero2;
            break;

        case '/':
            $resultado = $numero1 / $numero2;
            break;

        default:
            $resultado = $numero1 + $numero2;
            break;
    }


    echo "El resultado es: ".$resultado;

?>