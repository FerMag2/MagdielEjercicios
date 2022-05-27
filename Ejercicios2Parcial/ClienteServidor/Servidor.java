import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

public class Servidor {
 
    public static void main(String args[]) throws IOException {
        ServerSocket server = new ServerSocket(5000);
        Socket c = server.accept();
        BufferedReader in = new BufferedReader(new InputStreamReader(c.getInputStream()));
        PrintWriter out= new PrintWriter(c.getOutputStream());
        //Protocolo comunicacion: Primero Servidor - Cliente
        String line="";
        do {
        	line = in.readLine();
            System.out.println(line);
            if(line.equals("bye")) {
            	 out.println(line);
            }else {
            	out.println("OK desde ek servidor:"+ line);
            }
            out.flush();
            out.println("OK desde ek servidor:"+ line); 
        }while(!line.equals("bye"));
        c.close();
        server.close();   
    }
}