package docprincipal;
import java.io.*;
import java.net.*;
import org.jsoup.nodes.Document;
import org.jsoup.Jsoup;

public class DocumentoPrincipal {
    public static Document getHTML(String host) {
        Document html = null;

        try {
            html = Jsoup.connect(host).get();
        } catch (Exception e) {
            System.out.print("Error al obtener HTML");
        }
        return html;
    }
}