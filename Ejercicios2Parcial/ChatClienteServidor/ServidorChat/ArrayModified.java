package clases;
import java.util.ArrayList;
import java.util.List;

public class ArrayModified {

    //Metodo para dividir el arrayList en una lista de listas
    public static <T> List<List<T>> dividirArray(ArrayList<T> datos,int n){  

        List<List<T>> resultado=new ArrayList<List<T>>(); 
        
        //Variables para el cociente y residuo
        int residuo; int cociente;
        
        //Calcular el residuo
        residuo =  datos.size ()% n;  
        
        //Calcular el cociente
        cociente = datos.size () / n;
        
        //Variable para usuarios conectados que se usuaran en caso que excedan el numero
        int usuariosUsados=0;

        //Variable para dar el rango de divisiones
        int rango = 0;  

        //Crear lista si el cociente es mayor o igual a 2
        if(cociente >= 2){

            for(int i=0;i<n;i++){  
                List<T> valor=null;  
                if(residuo>0){  
                    valor=datos.subList(i*cociente+rango, (i+1)*cociente+rango+1);  
                    residuo--;  
                    rango++;  
                }else{  
                    valor=datos.subList(i*cociente+rango, (i+1)*cociente+rango);  
                }
    
                resultado.add(valor);  
            }  

        //En caso que el cociente no sea 2, se buscara un numero de usuarios con el 
        //que se garantice que al menos les toque 2 numeros para operar   
        } else if (cociente < 2){

            for(int w=n; w > 1; w--){
               
                cociente = datos.size () / w;    
                if(cociente >= 2){

                    usuariosUsados = w;
                    residuo =  datos.size ()% w;
                    break;

                }
            }

            for(int i=0;i<usuariosUsados;i++){  
                List<T> valor=null;  
                if(residuo>0){  
                    valor=datos.subList(i*cociente+rango, (i+1)*cociente+rango+1);  
                    residuo--;  
                    rango++;  
                }else{  
                    valor=datos.subList(i*cociente+rango, (i+1)*cociente+rango);  
                }
    
                resultado.add(valor);  
            }
        }
        System.out.println(usuariosUsados);
        return resultado;  
    }
    
    //Metodo para crear lista del factorial n hasta 2 
    //No se toma el 1 ya que no afecta mucho a la operacion
    public static ArrayList<Integer> hacerLista(int cantidad){

        ArrayList<Integer> listaNumeros=new ArrayList<>(); 
        for(int i=cantidad; i>1; i--){

            listaNumeros.add(i);  
 
        }
        return listaNumeros;
    }
}