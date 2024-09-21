using Deletar1_09_24_;

internal class Program
{
    private static void Main(string[] args)
    {
        Equacao obj = new Equacao();
        obj.LerDados();
        Console.WriteLine("O valor de Delta é: "+obj.SegundoGrau());
        obj.lerRaio();
        
        Calculo obj2 = new Calculo();
        Console.WriteLine(obj2.Quadrado(obj.getA(), obj.getB(), obj.getC()));
       
    }

}