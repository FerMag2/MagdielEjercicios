package ip;
import java.net.*;
public class DireccionIp {
    public String direccion(String host) {
        try {
            Socket socket = new Socket(host, 80);
            String ip = socket.getInetAddress().getHostAddress();
            return ip;
        } catch (Exception e) {
        }
        return null;
    }
}