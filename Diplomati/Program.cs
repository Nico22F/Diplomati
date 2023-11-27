using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomati
{
    internal class Program
    {
        public class CalcoloQuadratoeCubo
        {
            protected double _lato { get; set; }

            public CalcoloQuadratoeCubo (double _lato)
            {
                this._lato = _lato;
            }

            // calcolo area e perimetro del quadrato
            public void CalcoloQuadrato()
            {
                double a = _lato * _lato;
                double p = _lato + _lato + _lato + _lato;

                Console.WriteLine($"L'area del quadrato è di {a} cm, il perimetro è di {p} cm");
            }

           
        }

        public class Cubo : CalcoloQuadratoeCubo
        {
            public Cubo(double _lato) : base(_lato)
            {

            }
            public void CalcoloCubo()
            {
                double a = (_lato * _lato) * 6;
                double p = _lato * _lato * _lato;

                Console.WriteLine($"L'area del cubo è di {a} cm, il perimetro è di {p} cm");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il lato");
            double lato = Convert.ToDouble(Console.ReadLine());
            CalcoloQuadratoeCubo a = new CalcoloQuadratoeCubo(lato);
            a.CalcoloQuadrato();
            Cubo c = new Cubo(lato);
            c.CalcoloCubo();
        }
    }
}
