using System;

namespace DPRN2_U2_A2_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
                int eleccion=0;
                Console.WriteLine("*******************************************\nBienvenido a la creación de habitantes\n*******************************************");
                Console.WriteLine("Por favor elige un país: \n1.- España\n2.- Inglaterra\n3.- Italia\n4.- Alemania");
                var opcion = Console.ReadLine();
                eleccion = int.Parse(opcion);
                switch(eleccion){
                    case 1 when (eleccion==1):
                    PaisEuropeo paieseuropeo = new PaisEuropeo(1);
                    paieseuropeo.mostrarPaisElegido();
                    System.Console.WriteLine("Vamos a crear un habitante español. Por favor elige qué deseas hacer:");
                    System.Console.WriteLine("1.-Saludar\n2.-Bailar\n3.-Conocer una frase típica\n");
                    var elige = Console.ReadLine();
                    int metodoelegido = int.Parse(elige);
                    if(metodoelegido==1){
                        paieseuropeo.saludo();
                    }
                    if(metodoelegido==2){
                        paieseuropeo.baila();
                    }
                    if(metodoelegido==3){
                        paieseuropeo.fraseIconica();
                    }
                    break;
                    case 2 when (eleccion==2):
                    PaisEuropeo paieseuropeo2 = new PaisEuropeo(2);
                    paieseuropeo2.mostrarPaisElegido();
                    System.Console.WriteLine("Vamos a crear un habitante español. Por favor elige qué deseas hacer:");
                    System.Console.WriteLine("1.-Saludar\n2.-Bailar\n3.-Conocer una frase típica\n");
                    var eligedos = Console.ReadLine();
                    int metodoelegidodos = int.Parse(eligedos);
                    if(metodoelegidodos==1){
                        paieseuropeo2.saludo();
                    }
                    if(metodoelegidodos==2){
                        paieseuropeo2.baila();
                    }
                    if(metodoelegidodos==3){
                        paieseuropeo2.fraseIconica();
                    }
                    break;
                    case 3 when (eleccion==3):
                    PaisEuropeo paieseuropeo3 = new PaisEuropeo(3);
                    paieseuropeo3.mostrarPaisElegido();
                    System.Console.WriteLine("Vamos a crear un habitante español. Por favor elige qué deseas hacer:");
                    System.Console.WriteLine("1.-Saludar\n2.-Bailar\n3.-Conocer una frase típica\n");
                    var eligetres = Console.ReadLine();
                    int metodoelegidotres = int.Parse(eligetres);
                    if(metodoelegidotres==1){
                        paieseuropeo3.saludo();
                    }
                    if(metodoelegidotres==2){
                        paieseuropeo3.baila();
                    }
                    if(metodoelegidotres==3){
                        paieseuropeo3.fraseIconica();
                    }
                    break;
                    case 4 when (eleccion==4):
                    PaisEuropeo paieseuropeo4 = new PaisEuropeo(4);
                    paieseuropeo4.mostrarPaisElegido();
                    System.Console.WriteLine("Vamos a crear un habitante español. Por favor elige qué deseas hacer:");
                    System.Console.WriteLine("1.-Saludar\n2.-Bailar\n3.-Conocer una frase típica\n");
                    var eligecuatro = Console.ReadLine();
                    int metodoelegidocuatro = int.Parse(eligecuatro);
                    if(metodoelegidocuatro==1){
                        paieseuropeo4.saludo();
                    }
                    if(metodoelegidocuatro==2){
                        paieseuropeo4.baila();
                    }
                    if(metodoelegidocuatro==3){
                        paieseuropeo4.fraseIconica();
                    }
                    break;
                }
        }
    }
}
