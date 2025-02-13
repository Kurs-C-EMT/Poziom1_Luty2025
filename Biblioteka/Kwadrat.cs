using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Kwadrat : Prostokąt
    {
        public Kwadrat(Punkt lg, int a) : base(lg, a, a)
        {
        }

        public override void Rysuj()
        {
            Console.WriteLine("Rysujemy kwadrat");
        }

        public override string Serializuj()
        {
            return $"{(short)TypFiguryEnum.Kwadrat};{pd.x};{pd.y};{lg.x};{lg.y}";
        }
    }
}
