//Crearemos objetos de super Heroes


//importamos nuestras clases
using ObejtosC_;
using ObejtosC_.Models;
//niveles de los superpoderes
using System.Text;

// creamos poderes
var PoderVolar = new SuperPoder();
PoderVolar.Nombre = "Volar";
PoderVolar.Descripcion = "Planear en el aire";
PoderVolar.Nivel = NivelPoder.NivelDos;

var SuperFuerza = new SuperPoder();
SuperFuerza.Nombre = "Powerrrrrrrr";
SuperFuerza.Descripcion = "Te ahce mazeton";
SuperFuerza.Nivel = NivelPoder.NivelTres;

var Regeneracion= new SuperPoder();
Regeneracion.Nombre = "Rege";
Regeneracion.Descripcion = "Te Cura mientras peleas";
Regeneracion.Nivel = NivelPoder.NivelTres;


//Un nuevo SuperHeroe de la class
var superMan = new SuperHeroe();
superMan.Id = 1;
superMan.Nombre = "              SuperMan            ";
superMan.IdentidadSecreta = "Clark";
superMan.Ciudad = "Metropolis";
superMan.PuedeVolar = true;
//Lista de superpoderes de super man
List<SuperPoder> poderesSuperMan = new List<SuperPoder>();
poderesSuperMan.Add(PoderVolar);
poderesSuperMan.Add(SuperFuerza);
superMan.SuperPoderes = poderesSuperMan;
//usamos el metodo abstrac
string resultSalvarMundo = superMan.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);
//usamos el metodo virtuak
string resultSalvarTierra = superMan.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);


var superMan2 = new SuperHeroe();
superMan2.Id = 1;
superMan2.Nombre = "SuperMan";
superMan2.IdentidadSecreta = "Clark";
superMan2.Ciudad = "Metropolis";
superMan2.PuedeVolar = true;

//SON parecidas a las clases 
SuperHeroeRecord superHeroeRecord = new SuperHeroeRecord(1, "SuperMan", "Clark");
SuperHeroeRecord superHeroeRecord2 = new SuperHeroeRecord(1, "SuperMan", "Clark");
Console.WriteLine(superHeroeRecord==superHeroeRecord2);


//ejecutamos el metodo
string resultSuperPoderes = superMan.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
//empezamos por la calse


//Creacmos un antiheroe
var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar=false;
List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(Regeneracion);
poderesWolverine.Add(SuperFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

//usamos el metodo de antiheroe
string accionAntiheore = wolverine.RealizarAccionDeAntiHeroe("Ataca a la policia");
Console.WriteLine(accionAntiheore);

//imprimimos un metodo de nuestra interface
var imprimirIndo = new ImprimirInfo();
imprimirIndo.ImprimerSuperHeroe(wolverine);
enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
//Record
public record SuperHeroeRecord(int Id,string Nombre,string IdentidadSecreta);