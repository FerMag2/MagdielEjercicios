package clases;

import java.math.BigInteger;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JOptionPane;

//Clase en la que se maneja la comunicación del lado del servidor.
public class Servidor extends Thread{
    
    // Socket servidor para escuchar cuando los clientes se conectan e incluirlos en el chat
    private ServerSocket serverSocket;
    
    /*
     * Lista de todos los hilos de comunicación, para cada cliente se instancia uno 
     * de estos hilos ya que cada hilo esta escuchando permanentemente lo que dicho 
     * cliente envía al servidor. 
     */
     ArrayList<HiloCliente> clientes;
     ArrayList<Factorial> bdFactoriales;
    
    public static ArrayList<String> Operaciones = new ArrayList<>();
    public static List<List<String>> listaDividida = null;

    public int operacionesRecibidas=0;
    public int usuariosTrabajando;
    public  String referenciaFactorial;
    public int numeroFactorial;
    
    // Variable que almacena la ventana que gestiona la interfaz gráfica del servidor.
    private final VentanaS ventana;

    // Variable que almacena el puerto que el servidor usará para escuchar. 
    private final String puerto;
    
    //Correlativo para diferenciar a los múltiples clientes que se conectan
    static int correlativo;
    public static boolean vuelta;
    Factorial  f;
    
    public Servidor(String puerto, VentanaS ventana) {
        correlativo=0;
        this.puerto=puerto;
        this.ventana=ventana;
        clientes=new ArrayList<>();
        bdFactoriales = new ArrayList<>();
        this.start();
        
    }
    
    /* Método sobre el que corre el bucle infinito que tiene como función escuchar
     * permenentemente en espera de conexiones de nuevos clientes. */    
    public void run() {

        try {
            serverSocket = new ServerSocket(Integer.valueOf(puerto));
            ventana.addServidorIniciado();

            while (true) {
                HiloCliente h;
                Socket socket;
                socket = serverSocket.accept();

                agregarLog("------------------------------------------------------------------------ \n");
                h = new HiloCliente(socket, this);               
                h.start();
                agregarLog("Conexion: " + socket + "\n");

            }

        } catch (Exception e) {
            JOptionPane.showMessageDialog(ventana, "El servidor no se ha podido iniciar,\n"
                                                 + "puede que haya ingresado un puerto incorrecto.\n"
                                                 + "Esta aplicación se cerrará.");
            System.exit(0);
        }                
    }        
    
    //Ciclo que devuelve una lista con los identificadores de todos los clientes conectados.
    ArrayList<String> getUsuariosConectados() {
        ArrayList<String>usuariosConectados=new ArrayList<>();
        clientes.stream().forEach(c -> usuariosConectados.add(c.getIdentificador()));
        return usuariosConectados;
    }

    public void juntarOperaciones(String operacion) {
        
        Operaciones.add(operacion);
        operacionesRecibidas++;

        //agregarLog("\nOperacion : " + operacion + " \n");
        agregarLog("Operaciones recibidas: " + operacionesRecibidas);
        
        if(operacionesRecibidas == usuariosTrabajando){
            
            BigInteger multiplicacion = BigInteger.ONE;

            for(int i=0;i<Operaciones.size();i++){
        
                multiplicacion = multiplicacion.multiply(new BigInteger(Operaciones.get(i)));
                
            } 

            /*
            f = new Factorial(numeroFactorial, multiplicacion);
            bdFactoriales.add(f);

            System.out.println("Numero: " + f.getNumero() + "Resultado: " + f.getResultadoFactorial());
*/


            HiloCliente.enviarResultado(String.valueOf(multiplicacion));

            Operaciones.clear();
            operacionesRecibidas = 0;

        }
    }

    //Ciclo para obtener el numero de usuarios conectados al servidor
    public int numUsuariosConectados(){

        return getUsuariosConectados().size();

    }

    // Método que agrega una linea al log de la interfaz gráfica del servidor.
    void agregarLog(String texto) {
        ventana.agregarLinea(texto);
    }
}