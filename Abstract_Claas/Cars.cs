using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Claas
{
     abstract class Cars
    {
        public string model;
        public string make;
        public int enginesize;

        //Do not print variables within function abstract
        public abstract void Printmodel();
        public abstract void Printmake();
        public abstract void Printanginesize();
    }
}
