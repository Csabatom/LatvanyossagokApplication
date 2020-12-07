using System;
using System.Collections.Generic;
using System.Text;

namespace LatvanyossagokApplication
{
    public class Varos
    {
        private int id;
        private String nev;
        private int lakossag;

        public Varos(int id, string nev, int lakossag)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
        }

        public override string ToString()
        {
            return nev + " - Lakosság: " + lakossag + " fő";
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Lakossag
        {
            get { return lakossag; }
            set { lakossag = value; }
        }
    }
}
