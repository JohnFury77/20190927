using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project20190927
{
    class Festmeny
    {
        private string cim;
        private string festo;
        private string stilus;
        private int licitekSzama = 0;
        private int legmagasabbLicit = 0;
        private DateTime legutolsoLicitIdeje;
        private bool elkelt = false;

        public string Cim { get => cim; set => cim = value; }
        public string Festo { get => festo; set => festo = value; }
        public string Stilus { get => stilus; set => stilus = value; }
        public int LicitekSzama { get => licitekSzama; set => licitekSzama = value; }
        public int LegmagasabbLicit { get => legmagasabbLicit; set => legmagasabbLicit = value; }
        public DateTime LegutolsoLicitIdeje { get => legutolsoLicitIdeje; set => legutolsoLicitIdeje = value; }
        public bool Elkelt { get => elkelt; set => elkelt = value; }

        public Festmeny(string cim, string festo, string stilus, int licitekSzama, int legmagasabbLicit, DateTime legutolsoLicitIdeje, bool elkelt)
        {
            this.Cim = cim;
            this.Festo = festo;
            this.Stilus = stilus;
            this.LicitekSzama = licitekSzama;
            this.LegmagasabbLicit = legmagasabbLicit;
            this.LegutolsoLicitIdeje = legutolsoLicitIdeje;
            this.Elkelt = elkelt;
        }

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
        }

        public void Kiir()
        {
            Console.WriteLine(this.festo+": "+this.cim+"("+this.stilus+")");
            if (elkelt == false)
            {
                Console.WriteLine("Nem kelt el.");
            }
            else if (elkelt == true)
            {
                Console.WriteLine("Elkelt");
            }
            Console.WriteLine(this.legmagasabbLicit + "$ - " + this.legutolsoLicitIdeje + "(összesen: " + this.licitekSzama + " db)");
        } 
        public static List<Festmeny> beolvas()
        {

            string [] festmeny = File.ReadAllLines("festmenyek.csv",Encoding.UTF8);
            List<Festmeny> lista = new List<Festmeny>(); 
            foreach (var f in festmeny)
            {       
                string[] tomb = f.Split(';');
                Festmeny fe = new Festmeny(tomb[0], tomb[1], tomb[2]);
                lista.Add(fe);

            }
            return lista;
            
        }
    }
}
