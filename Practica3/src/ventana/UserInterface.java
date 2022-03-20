package ventana;
import java.awt.*;
import java.awt.event.*;
import java.util.*;
import javax.swing.*;

import directorio.Directorios;
import docprincipal.DocumentoPrincipal;
import ip.DireccionIp;
import tiempo.TiempoCarga;

public class UserInterface extends JFrame {

    String host1 = "itescam.edu.mx";
    String host = "https://itescam.edu.mx";

    public UserInterface() {
    	this.setBackground(Color.BLUE);
        initComponets();
    }

    public void initComponets() {
        this.setLayout(new BorderLayout());
        this.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);

        btnIP = new JButton("Ip");
        btnIP.setFocusable(false);
        btnIP.addActionListener(e -> btnIPActionPerformed(e));
        btnIP.setBackground(Color.RED);

        btnDirectorio = new JButton("Directorio");
        btnDirectorio.setFocusable(false);
        btnDirectorio.addActionListener(e -> btnDirectorioActionPerformed(e));
        btnDirectorio.setBackground(Color.red);

        btnDocPrincipal = new JButton("Principal");
        btnDocPrincipal.setFocusable(false);
        btnDocPrincipal.addActionListener(e -> btnDocPrincipalActionPerformed(e));
        btnDocPrincipal.setBackground(Color.red);

        btnTiempo = new JButton("Tiempo Carga");
        btnTiempo.setFocusable(false);
        btnTiempo.addActionListener(e -> btnTiempoDeCargarActionPerformed(e));
        btnTiempo.setBackground(Color.red);

        contButtons = new JPanel();
        contButtons.add(btnIP);
        contButtons.add(btnDirectorio);
        contButtons.add(btnDocPrincipal);
        contButtons.add(btnTiempo);
        contButtons.setBackground(Color.GREEN);

        txtResultado = new JTextArea();
        txtResultado.setFont(new Font("Monospaced", 0, 16));
        txtResultado.setMargin(new Insets(20, 20, 20, 20));
        txtResultado.setFocusable(false);
        txtResultado.setRequestFocusEnabled(false);
        txtResultado.setBackground(Color.YELLOW);

        scrollPane = new JScrollPane();
        scrollPane.setBorder(null);
        scrollPane.setFocusTraversalPolicyProvider(true);
        scrollPane.setViewportView(txtResultado);

        add(contButtons, BorderLayout.NORTH);
        add(scrollPane, BorderLayout.CENTER);
        this.setSize(800, 500);
        this.setLocationRelativeTo(null);
        this.setVisible(true);
    }

    private void btnIPActionPerformed(ActionEvent e) {
        txtResultado.setText("");
        dirIP = new DireccionIp();
        txtResultado.setText("Direccion IP \n"
                + dirIP.direccion(host1));
    }

    private void btnDirectorioActionPerformed(ActionEvent e) {
        txtResultado.setText("");
        dirs = new Directorios();
        txtResultado.setText("Documento Principal \n"
                + Arrays.toString(dirs.directoriosExtistentes(host)));
    }

    private void btnDocPrincipalActionPerformed(ActionEvent e) {
        txtResultado.setText("");
        docP = new DocumentoPrincipal();
        txtResultado.setText("Documento principal: \n"
                + docP.getHTML(host));
    }

    private void btnTiempoDeCargarActionPerformed(ActionEvent e) {
        txtResultado.setText("");
        time = new TiempoCarga();
        txtResultado.setText("Tiempo de Carga \n"
                + time.carga(host1) + " Segundos");
    }

    JButton btnIP;
    JButton btnDirectorio;
    JButton btnDocPrincipal;
    JButton btnTiempo;
    JPanel contButtons;
    JScrollPane scrollPane;
    JTextArea txtResultado;
    DireccionIp dirIP;
    Directorios dirs;
    DocumentoPrincipal docP;
    TiempoCarga time;
}
