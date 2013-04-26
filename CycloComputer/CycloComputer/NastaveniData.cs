using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CycloComputer
{
    public class NastaveniData
    {
        public bool casovyRezim;
        public float obvod;

        public bool IsNepretrzityCasovyRezim
        {
            get
            {
                return casovyRezim;
            }
            set
            {
                casovyRezim = value;
            }
        }

        public float ObvodKola
        {
            get
            {
                return obvod;
            }
            set
            {
                obvod = value;
            }
        }

        public static void Nacti()
        {
            throw new System.NotImplementedException();
        }

        public static void Uloz()
        {
            throw new System.NotImplementedException();
        }
    }
}
