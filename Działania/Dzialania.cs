using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Działania
{
    internal class Dzialania
    {
        public DziałaniaHistoria[] Historia = { };
        public int wynik;

        public void Dodaj(int a, int b)
        {
            wynik = a + b;
            DodajDoHistorii(a, b, DziałaniaEnum.Dodawanie);
        }

        public void DodajDoHistorii(int a, int b, DziałaniaEnum typ)
        {
            DziałaniaHistoria[] temp = new DziałaniaHistoria[Historia.Length + 1];
            for (int i = 0; i < Historia.Length; i++)
            {
                temp[i] = Historia[i];
            }

            DziałaniaHistoria nowyWpis = new();
            nowyWpis.typ = typ;
            nowyWpis.a = a;
            nowyWpis.b = b;
            temp[^1] = nowyWpis;
            Historia = temp;
        }

        public void Odejmij(int a, int b)
        {
            wynik = a - b;
            DodajDoHistorii(a, b, DziałaniaEnum.Odejmowanie);
        }

        public void CofnijOstatniaOperacje()
        {
            if (Historia.Length > 0)
            {
                if (Historia.Length > 1)
                {
                    DziałaniaHistoria poprzedniaOperacja = Historia[^2];
                    switch (poprzedniaOperacja.typ)
                    {
                        case DziałaniaEnum.Dodawanie:
                            wynik = poprzedniaOperacja.a + poprzedniaOperacja.b;
                            break;
                        case DziałaniaEnum.Odejmowanie:
                            wynik = poprzedniaOperacja.a - poprzedniaOperacja.b;
                            break;
                        case DziałaniaEnum.Silnia:
                            wynik = SilniaRek(poprzedniaOperacja.a);
                            break;
                    }
                }
                else
                {
                    wynik = 0;
                }

                DziałaniaHistoria[] temp = new DziałaniaHistoria[Historia.Length - 1];
                for (int i = 0; i < temp.Length; i++) 
                {
                    temp[i] = Historia[i];
                }

                Historia = temp;
            }
        }

        public void Silnia(int a)
        {
            wynik = SilniaRek(a);
            DodajDoHistorii(a, 0, DziałaniaEnum.Silnia);
        }

        public int SilniaRek(int a)
        {
            if(a > 1)
            {
                int wynikRek = SilniaRek(a - 1);
                return a * wynikRek;
            }
            else 
            { 
                return 1; 
            }
        }
    }
}
