namespace Ejercicio_01{
class Program
{
    
         static void Main(string[]args){
         Persona persona = new Persona();
         persona.saludad();
         Estudiante estudiante = new Estudiante();
         estudiante.setEdad(19);
         estudiante.saludad();
         estudiante.MostrarEdadd();
         estudiante.Estudiar();
         Profesor profe=new Profesor();
         profe.setEdad(100);
         profe.saludad();
         profe.explicar();
    }
}
}