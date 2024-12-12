using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObejtosC_.Interfaces;

namespace ObejtosC_
{
    internal class ImprimirInfo
    {
        public void ImprimerSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre:{superHeroe.Nombre}");
            Console.WriteLine($"Identidad: {superHeroe.IdentidadSecreta}");
        }
    }
}
