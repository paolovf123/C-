using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObejtosC_.Interfaces;

namespace ObejtosC_.Models
{
    class SuperHeroe : Heroe , ISuperHeroe
    {
        private string _Nombre;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreEIdentidadSecreta
        {
            get 
            {
                return $"{Nombre}({IdentidadSecreta})";
            } 
        }
        public int Id { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        //añadiremos un constructor(establece los valores por defecto de nuestra clase al momento de inicializarla)
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        //creamos un metodo para nuestra clase
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el poder: {item.Nombre}!!");
            }
            return sb.ToString();
        }
        //implemnetación para nuestro abstract(metodo sin implementación)
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ah salvado al mundo";
        }
        //imprementación para nuestro virtual(polimorfismo)
        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} salvo la tierra";
        }
    }
}
