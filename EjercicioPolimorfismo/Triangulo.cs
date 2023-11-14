using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Triangulo : Figura
    {


        double LadoA {  get; set; } 
        double LadoB { get; set; }  
        double LadoC {  get; set; } 


        public Triangulo(double ladoA, double ladoB, double ladoC) { 
          LadoA = ladoA;    
          LadoB = ladoB;  
          LadoC = ladoC;
        
        }  

        public override double CalcularArea()
        {

            double cal = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(cal *(cal - LadoA) * (cal -LadoB) * (cal - LadoC));  
        }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
