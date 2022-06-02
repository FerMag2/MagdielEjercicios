package clases;

import java.math.BigInteger;

public class Factorial {

    private int numero;
    private BigInteger resultadoFactorial;


    public Factorial(int numero, BigInteger resultadoFactorial) {
        this.numero = numero;
        this.resultadoFactorial = resultadoFactorial;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public BigInteger getResultadoFactorial() {
        return resultadoFactorial;
    }
    
    public void setResultadoFactorial(BigInteger resultadoFactorial) {
        this.resultadoFactorial = resultadoFactorial;
    }

}