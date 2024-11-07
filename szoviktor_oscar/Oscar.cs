using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoviktor_oscar
{
    internal class Oscar
    {
        public string FilmAzonosito { get; set; }
        public string FilmCime { get; set; }
        public int Ev { get; set; }
        public int Dij { get; set; }
        public int Jelol { get; set; }

        public Oscar(string sor) 
        {
            var s = sor.Split("\t");
            this.FilmAzonosito = s[0];
            this.FilmCime = s[1];
            this.Ev = int.Parse(s[2]);
            this.Dij = int.Parse(s[3]);
            this.Jelol = int.Parse(s[4]);
        }
    }
}
