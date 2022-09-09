public class ropa{

    private string marca, disenador;
    private int  valor;

    public string getmarca(){
       return (this.marca);
    }

public string setmarca(string marca){
        return this.marca=marca;
        }
 public string getdiseñador(){
        return(this.disenador);
    }
    public string setdiseñador(string marca){
        return this.disenador=marca;
        }

 public int getvalor(){
        return (this.valor);
 }
public void setvalor(int valor){
        this.valor=valor;
}
public void tostring(){ 
    Console.WriteLine("el diseñador "+this.disenador+" creo la marca" +this.marca+" que tiene el valor de "+this.valor);
}
}

