import javax.swing.*;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;


public class Game implements KeyListener {
    
    public static void main(String[] args) {
        Game game = new Game();
    }

   
    private GamePanel gamePanel;

    
    public Game() {
        String[] options = new String[] {"Facil", "Medio", "Dificil"};
        String message = "F�cil har� movimientos totalmente aleatorios,\\nMedio se centrar� en �reas donde encuentra barcos\",\n" + 
        		"                + \"\\ny Duro tomar� decisiones m�s inteligentes sobre Medio.";
        int difficultyChoice = JOptionPane.showOptionDialog(null, message,
                "Elije la dificultad",
                JOptionPane.DEFAULT_OPTION, JOptionPane.PLAIN_MESSAGE,
                null, options, options[0]);

        JFrame frame = new JFrame("Battleship");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setResizable(false);

        gamePanel = new GamePanel(difficultyChoice);
        frame.getContentPane().add(gamePanel);

        frame.addKeyListener(this);
        frame.pack();
        frame.setVisible(true);
    }

    
    @Override
    public void keyPressed(KeyEvent e) {
        gamePanel.handleInput(e.getKeyCode());
    }

  
    @Override
    public void keyTyped(KeyEvent e) {}
   
    @Override
    public void keyReleased(KeyEvent e) {}
}
