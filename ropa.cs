public class almacen{

public static void Main(string[] args){

ropa spanish =new ropa ();
ropa nike=new ropa ();

spanish.setdiseñador("juan camilo");
spanish.setmarca("spanish");
spanish.setvalor(300000);
spanish.tostring();

nike.setdiseñador("andres");
nike.setmarca("nike");
nike.setvalor(400000);
nike.tostring();

if (spanish.getvalor() >= nike.getvalor()) {

Console.WriteLine ("spanish tiene mas valor");
            	}
		else {
            // Establece la accion por falso
                	Console.WriteLine ("nike tien mas valor");
            	}
// fin condicional
	
    // fin algoritmo

}
    }