using System;

namespace Ejercicio_01
{
    class Estudiante : Persona{

        public void Estudiar(){
          Console.WriteLine("Estoy estudiando");
        }
        public void MostrarEdadd(){
             Console.WriteLine($" Mi edad es{edad}años");
        }
        
        
    }
}
