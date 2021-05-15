class PaisEuropeo:Pais{
    public string inicio="Haz elegido ";
    public string bailando="El baile típico de ";
    public string espana="España";
    public string inglaterra="Inglaterra";
    public string italia="Italia";
    public string alemania="Alemania";
    public string frase ="Una frase típica del país elegido es: \n";
    public PaisEuropeo(int paisEurpeoElegido):base(paisEurpeoElegido){ } 

    public override string saludo(){
        string saludoPais="";
        if(paisElegido==1){
            saludoPais="¡Hola!";
            System.Console.WriteLine(inicio+espana+": "+saludoPais);
        }
        else if (paisElegido==2){
            saludoPais="Hello!";
            System.Console.WriteLine(inicio+inglaterra+": "+saludoPais);
        }
        else if (paisElegido==3){
            saludoPais="Ciao";
            System.Console.WriteLine(inicio+italia+": "+saludoPais);
        }else if (paisElegido==4){
            saludoPais="Hallo!";
            System.Console.WriteLine(inicio+alemania+": "+saludoPais);
        }
        return base.paisElegido+"";
    }

    public override string baila(){
        string bailePais=" ";
        if(paisElegido==1){
            bailePais="Flamenco";
            System.Console.WriteLine(bailando+espana+" es "+bailePais);
        }
        else if (paisElegido==2){
            bailePais="Morris Dance";
            System.Console.WriteLine(bailando+inglaterra+" es "+bailePais);
        }
        else if (paisElegido==3){
            bailePais="Tarantela";
            System.Console.WriteLine(bailando+inglaterra+" es "+bailePais);
        }
        else if (paisElegido==4){
            bailePais="Schuhplattler";
            System.Console.WriteLine(bailando+alemania+" es "+bailePais);
        }
        return base.paisElegido + "";
    }

    public override string fraseIconica(){
        string frasePais="";
        if(paisElegido==1){
            frasePais="'Dar la vuelta a la tortilla'";
            System.Console.WriteLine(inicio+espana+"."+frase+"\n"+frasePais);
        }
        else if (paisElegido==2){
            frasePais="'To pop one’s clogs'";
            System.Console.WriteLine(inicio+inglaterra+"."+frase+"\n"+frasePais);
        }else if (paisElegido==3){
            frasePais="'Stare con le mani in mano'";
            System.Console.WriteLine(inicio+italia+"."+frase+"\n"+frasePais);
        }else if (paisElegido==4){
            frasePais="'Das ist mir Wurst'";
            System.Console.WriteLine(inicio+alemania+"."+frase+"\n"+frasePais);
        }
        return inicio + base.paisElegido + frasePais;
    }
}