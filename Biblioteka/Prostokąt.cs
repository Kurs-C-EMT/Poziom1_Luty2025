using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Prostokąt
    {
        public Punkt lg;
        public Punkt pd;

        public Prostokąt(Punkt lg, Punkt pd)
        {
            this.lg = lg;
            this.pd = pd;
        }

        public Prostokąt(Punkt lg, int a, int b) : this(lg, new Punkt(lg.x + a, lg.y + b))
        {
        }

        public int PobierzBokA()
        {
            return Math.Abs(pd.x - lg.x);
        }

        public int PobierzBokB()
        {
            return Math.Abs(pd.y - lg.y);
        }

        public int PobierzPole()
        {
            int bokA = PobierzBokA();
            int bokB = PobierzBokB();
            return bokA * bokB;
        }

        public int PobierzObwód()
        {
            int bokA = PobierzBokA();
            int bokB = PobierzBokB();
            return 2 * bokA + 2 * bokB;
        }

        public virtual void Rysuj()
        {
            Console.WriteLine("Rysujemy prostokąt");
        }

        public virtual string Serializuj()
        {
            return $"{(short)TypFiguryEnum.Prostokąt};{pd.x};{pd.y};{lg.x};{lg.y}";
        }
    }
}
