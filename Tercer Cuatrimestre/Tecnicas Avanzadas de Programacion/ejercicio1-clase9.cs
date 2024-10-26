using System;

namespace GalagaGame
{

class abstract Trabajador {
    protected string nombre;
    protected string apellido;
    protected double sueldo;

    public Trabajador(string nombre, string apellido, double sueldo){
        this.nombre = nombre;
        this.apellido = apellido;
        this.sueldo = sueldo;
    }

    public Trabajador(string nombre, string apellido, double sueldo){
        this.nombre = "";
        this.apellido = "";
        this.sueldo = 0;
    }
    
    public string getNombre(){
        return nombre;
    }
    
    public void setNombre(string nombre){
        nombre = nombre;        
    }
    
    public string getApellido(){
        return apellido;
    }
    
    public void setApellido(string apellido){
        apellido = apellido;        
    }
    
        
    public string getSueldo(){
        return sueldo;
    }
    
    public void setSueldo(double sueldo){
        sueldo = sueldo;        
    }
    
}

class Jefe : Trabajador{
    protected List<Empleado> l_empleados;

    public Jefe(string nombre, string apellido, double sueldo, List<Empleado> empleados):base(nombre, apellido, sueldo){
         this.l_empleados = l_empleados;
    }    
}

class Empleado : Trabajador{
    public Jefe(string nombre, string apellido, double sueldo):base(nombre, apellido, sueldo){
    }    
}

}
