using System;
using System.Collections.Generic;
using System.Text;

namespace LatvanyossagokApplication
{
    public class Latvanyossag
    {
        private int id;
        private string nev;
        private string leiras;
        private int ar;
        private int varos_id;

        public Latvanyossag(int id, int varos_id, string nev, string leiras, int ar)
        {
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.varos_id = varos_id;
        }

        public override string ToString()
        {
            return nev;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Varos_id
        {
            get { return varos_id; }
            set { varos_id = value; }
        }

        public String Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public String Leiras
        {
            get { return leiras; }
            set { leiras = value; }
        }

        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }
    }
}
