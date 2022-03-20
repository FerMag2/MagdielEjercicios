package directorio;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

public class Directorios {
    String[] dirs;
    int i = 0;
    int tam = 0;
    public String[] directoriosExtistentes(String host) {
        try {
            Document doc = Jsoup.connect(host).get();
            Elements imports = doc.select("a[href]");
            dirs = new String[imports.size()];
            tam = imports.size();

            for (Element link : imports) {
                dirs[i] = (link.tagName() + link.attr("abs:href") + "\n");
                i++;
            }
            return dirs;
        } catch (Exception e) {
        }
        return null;
    }

    public int getTam() {
        return tam;
    }

}