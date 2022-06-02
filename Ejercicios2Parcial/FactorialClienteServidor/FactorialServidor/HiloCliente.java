package clases;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;

/*
 * Los objetos de esta clase son hilos que al correr escuchan permanentemente
 * lo que los clientes puedan decir, hay un hilo para cada cliente que se conecta al servidor y dicho 
 * hilo tiene como función escuchar solamente a ese cliente.
 */
public class HiloCliente extends Thread{
    
    //Socket que se utiliza para comunicarse con el cliente.
    private final Socket socket;    
    
    //Stream con el que se envían objetos al servidor.
    private ObjectOutputStream objectOutputStream;

    //Stream con el que se reciben objetos del servidor. 
    private ObjectInputStream objectInputStream;

    //Servidor al que pertenece este hilo. 
    private static Servidor server;
    
    //Para identificar quien fue la persona que solicito el calculo del factorial
    public static String identificadorFactorial;

    //Para obtener la cantidad de usuarios que estan realizando operaciones
    public static int numUsariosOperando=0;

    //Identificador único del cliente con el que este hilo se comunica.
    private String identificador;
    
    /* Variable booleana que almacena verdadero cuando este hilo esta escuchando
     * lo que el cliente que atiende esta diciendo. */
    private boolean escuchando;
    String resultadoBuscado = "";

    public HiloCliente(Socket socket,Servidor server) {
        this.server=server;
        this.socket = socket;
        
        try {
            objectOutputStream = new ObjectOutputStream(socket.getOutputStream());
            objectInputStream = new ObjectInputStream(socket.getInputStream());
        } catch (IOException ex) {
            System.err.println("Error en la inicialización de componentes de entrada y salida");
        }
    }
    
    //Método encargado de cerrar el socket con el que se esta comunicando.
    public void desconectar() {
        try {
            socket.close();
            escuchando=false;
        } catch (IOException ex) {
            System.err.println("Error al cerrar el socket de comunicación con el cliente.");
        }
    }
    
    //Sobreescritura del método de Thread, es acá en donde se monta el ciclo infinito.        
    public void run() {
        try{
            escuchar();
        } catch (Exception ex) {
            System.err.println("Error al llamar al método readLine del hilo del cliente.");
        }
        desconectar();
    }
        
    /*Método que constantemente esta escuchando todo lo que es enviado por 
     * el cliente que se comunica con él.*/        
    public void escuchar(){  

        escuchando=true;
    
        while(escuchando) {
            try {
                Object aux=objectInputStream.readObject();
                if(aux instanceof ArrayList){
                    ejecutar((ArrayList<String>)aux);
                }
            } catch (Exception e) {           

                System.err.println("Error al leer lo enviado por el cliente");
 
            }
        }
    }
    
    /*Método que realiza determinadas acciones dependiendo de lo que el socket haya recibido y lo que
     * este le envie el método, en él se manejan una serie de códigos.
     *@param lista*/        
    public void ejecutar(ArrayList<String> lista){
        
        // 0 - El primer elemento de la lista es siempre el tipo
        String tipo=lista.get(0);
        switch (tipo) {
            case "SOLICITUD_CONEXION":
                // 1 - Identificador propio del nuevo usuario
                confirmarConexion(lista.get(1));
                break;
                
            case "SOLICITUD_DESCONEXION":
                // 1 - Identificador propio del nuevo usuario
                confirmarDesConexion();
                break;    
                
            case "MENSAJE":
                // 1      - Cliente emisor
                // 2      - Cliente receptor
                // 3      - Mensaje
                
                server.clientes.stream().forEach((h) -> h.enviarMensaje(lista));
                break;

            case "FACTORIAL":
                
                identificadorFactorial = lista.get(1);
                server.referenciaFactorial = identificadorFactorial;
                server.numeroFactorial = Integer.parseInt(lista.get(2));
                
                /*
                for(int i=0; i<server.bdFactoriales.size(); i++){

                    if(server.bdFactoriales.get(i).getNumero() == Integer.parseInt(lista.get(2))){

                        resultadoBuscado = String.valueOf(server.bdFactoriales.get(i).getResultadoFactorial());
                    }
                }

                if(resultadoBuscado.equals(lista.get(2))){

                    System.out.println("Si se encontró");
                    enviarResultado(resultadoBuscado);

                }
                else{
*/
                    generarPaquete(Integer.parseInt(lista.get(2)));
                
                
  
                break;
            
            case "OPERACION DEVUELTA":

                if(server.usuariosTrabajando == 1) {

                    enviarResultado(lista.get(1));
                    
                }else if (server.usuariosTrabajando >= 2){

                    server.juntarOperaciones(lista.get(1)); 
                    
                }
                break;
             
            default:
            break;
        }
    }
    
    static void enviarResultado(String resultado) {

        ArrayList<String> listaResultado=new ArrayList<>();
 
        listaResultado.add("RESULTADO");
        listaResultado.add(resultado);

        server.clientes.stream().filter(h -> (identificadorFactorial.equals(h.getIdentificador())))
        .forEach((h) -> h.enviarMensaje(listaResultado));

    }

    public static void enviarOperacion(List<List<String>> operaciones) {

        ArrayList<String> listaOperacion=new ArrayList<>();
 
        for(int i=0; i < numUsariosOperando; i++){
            
            listaOperacion.add("OPERACION");
         
            String destinatario=server.getUsuariosConectados().get(i);
            
            for(int y=0; y < operaciones.get(i).size();y++){
                
                listaOperacion.add(operaciones.get(i).get(y));

            }
            
            server.agregarLog("Enviado a: " + destinatario + " su valor de " + listaOperacion + "\n" );

            server.clientes.stream().filter(h -> (destinatario.equals(h.getIdentificador())))
            .forEach((h) -> h.enviarMensaje(listaOperacion));

            listaOperacion.clear();
        }
    }

    //Metodo para generar el paquete a enviar a los usuarios
    private void generarPaquete(int numeroFactorial) {

        ArrayList<String> factorialDescompuesto = ArrayModified.hacerLista(numeroFactorial);
        numUsariosOperando = server.numUsuariosConectados();
        List<List<String>> listaDividida = ArrayModified.dividirArray(factorialDescompuesto, numUsariosOperando);
        numUsariosOperando = ArrayModified.usuariosUsados;
        server.usuariosTrabajando = numUsariosOperando;
        enviarOperacion(listaDividida);
        
    }
    
    //Método para enviar un mensaje al cliente atraves del socket.
    public void enviarMensaje(ArrayList<String> lista){
        try {
            objectOutputStream.writeObject(lista);            
        } catch (Exception e) {
            System.err.println("Error al enviar el objeto al cliente.");
        }
    }    
    
    /* Una vez conectado un nuevo cliente, este método notifica a todos los clientes
     * conectados que hay un nuevo cliente para que lo agreguen a sus contactos.
     * @param identificador */
    
    private void confirmarConexion(String identificador) {
        Servidor.correlativo++;
        this.identificador=Servidor.correlativo+" - "+identificador;
        ArrayList<String> lista=new ArrayList<>();
        lista.add("CONEXION_ACEPTADA");
        lista.add(this.identificador);
        lista.addAll(server.getUsuariosConectados());
        enviarMensaje(lista);
        server.agregarLog("Nuevo cliente: "+this.identificador+"\n");
        server.agregarLog("------------------------------------------------------------------------\n");
        
        //enviar a todos los clientes el nombre del nuevo usuario conectado excepto a él mismo
        ArrayList<String> auxLista=new ArrayList<>();
        auxLista.add("NUEVO_USUARIO_CONECTADO");
        auxLista.add(this.identificador);
        server.clientes.stream().forEach(cliente -> cliente.enviarMensaje(auxLista));
        server.clientes.add(this); 
    }
    
    /*Método que retorna el identificador único del cliente dentro del chat.
     * @return*/
    public String getIdentificador() {
        return identificador;
    }
    
    /*Método que se invoca cuando el usuario al que atienede este hilo decide 
     * desconectarse, si eso pasa, se tiene que informar al resto de los usuarios que 
     * ya no pueden enviarle mensajes y que deben quitarlo de su lista de contactos.*/
    private void confirmarDesConexion() {
        ArrayList<String> auxLista=new ArrayList<>();
        auxLista.add("USUARIO_DESCONECTADO");
        auxLista.add(this.identificador);
        server.agregarLog("El cliente \""+this.identificador+"\" se ha desconectado. \n");
        this.desconectar();
        for(int i=0;i<server.clientes.size();i++){
            if(server.clientes.get(i).equals(this)){
                server.clientes.remove(i);
                break;
            }
        }

        server.clientes.stream().forEach(h -> h.enviarMensaje(auxLista));        
    }
}