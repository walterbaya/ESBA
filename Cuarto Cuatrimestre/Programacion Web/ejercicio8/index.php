<?php
    $nombre = "Roberto";

    echo $nombre;

    echo "</br>";

    $apellido = "Rodriguez";

    echo $apellido;

    echo "</br>";

    echo "Mi nombre es: ".$nombre." Y mi apellido es: ".$apellido;

    $Nombres[0] = "José";
    $Nombres[1] = "Aldo";
    $Nombres[2] = "María";

    echo $Nombres[2];

    echo "</br>";

    $Agenda[0]["Nombre"] = "Bender";
    $Agenda[0]["Apellido"] = "Rodriguez";
    $Agenda[1]["Nombre"] = "Aldo";
    $Agenda[1]["Apellido"] = "Martinez";
    $Agenda[2]["Nombre"] = "María";
    $Agenda[2]["Apellido"] = "Fernandez";

    for ($i = 0; $i <= 2; $i++){
        echo $Agenda[$i]["Nombre"];
        echo " ";
        echo $Agenda[$i]["Apellido"];
    }

    echo "</br>";

    echo "
    <table border = '1px'>
    <th>Nombre</th>
    <th>Apellido</th>;
    "

?>