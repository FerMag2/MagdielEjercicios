package clases;

import java.util.ArrayList;
import java.util.List;

public class prueba {
    
    public static void main(String[] args) {

        int n = 11;
        int usuariosConectados=10;

        ArrayList<Integer> lists = ArrayModified.hacerLista(n);
        List<List<Integer>> lista = ArrayModified.dividirArray(lists, usuariosConectados);

        int multipliaccion = lista.get(0).get(0)  * lista.get(0).get(1);

        System.out.println(multipliaccion);
        

          
    }
}