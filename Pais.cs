public class Pais{
    //Constructor vacío
    public Pais(){

    }
    //Datos miembro.
    protected int paisElegido;

    //Método Pais con parámetros
    public Pais(int paisElegido){
        this.paisElegido=paisElegido;
    }
    //Método para mostrar país elegido
    public void mostrarPaisElegido(){
        if(paisElegido==1){
            System.Console.WriteLine("País elegido: "+ paisElegido + ".- España");
        }else if(paisElegido==2){
            System.Console.WriteLine("País elegido: "+ paisElegido + ".- Inglaterra");
        }else if(paisElegido==3){
            System.Console.WriteLine("País elegido: "+paisElegido+".- Italia");
        }else if(paisElegido==4){
            System.Console.WriteLine("País elegio: "+paisElegido+".- Alemania");
        }
    }

    //Interfaz para el pais
    public int DatoPais{
        get{
            return paisElegido;
        }set{
            paisElegido = value;
        }
    }

    //Destructor
    ~Pais() {
        paisElegido=0; 
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}