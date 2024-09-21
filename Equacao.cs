/*implementoe uma classe chamada equação composta por três atributos privados a, b, c
Esse atributos são os coeficientes de um métoodo que realiza o cálculo de uma equação
do segunda grau. Esse método dee retornaro valor do delta, que é dado por b² - 4ac */

using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Deletar1_09_24_;

public class Equacao{

    //Atributos
    private double a,b,c;

    public Equacao(){
    }

//====================================
    public double getA(){
        return this.a;
    }

    public void setA(double a){
        this.a = a;
    }
//=====================================
    public double getB(){
        return this.b;
    }

    public void setB(double b){
        this.b = b;
    }
//=====================================
    public double getC(){
        return this.c;
    }

    public void setC(double c){
        this.c = c;
    }
//=====================================


    //metodos

    public void LerDados(){
        Console.WriteLine("Digite valor de a: ");
        setA(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("Digite valor de b: ");
        setB(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("Digite valor de c: ");
        setC(Convert.ToDouble(Console.ReadLine()));
    }

    /*
    public double A{get;set;}
    public double B{get;set;}
    public double C{get;set;}
    */

    
    public double SegundoGrau(){
        double delta=0;
        delta=Math.Pow(b,2)-(4*a*c);

        return delta;
    }

    public void lerRaio(){
        Console.WriteLine("Digite o valor do raio: ");
        Console.WriteLine("O volume é "+ this.VolumeEsfera(Convert.ToDouble(Console.ReadLine())));
    }



    public double VolumeEsfera(double R){
        double Volume=0;
        Volume=4/3 * 3.14 * Math.Pow(R,3);
        return Volume;
    }
  
}
