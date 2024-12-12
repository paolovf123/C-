using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejtosC_.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        //constructor
        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }
}
