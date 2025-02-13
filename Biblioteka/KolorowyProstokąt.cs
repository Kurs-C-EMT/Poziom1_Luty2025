using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class KolorowyProstokąt : Prostokąt
    {
        public string kolor { get; set; }

        public KolorowyProstokąt(Punkt lg, int a, int b, string kolor) : base(lg, a, b)
        {
            this.kolor = kolor;
        }

        public override void Rysuj()
        {
            Console.WriteLine("Rysowanie kolorowego prostokąta");
        }

        public override string Serializuj()
        {
            return $"{(short)TypFiguryEnum.KolorowyProstokąt};{pd.x};{pd.y};{lg.x};{lg.y};{kolor}";
        }
    }
}
