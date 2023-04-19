internal class Program
{
  private static void Main(string[] args)
  {
    int resultado1 = Soma(10, 20);
    Console.WriteLine(resultado1); //30

    double resultado2 = Soma(5.5, 6);
    Console.WriteLine(resultado2); //11,5

    double resultado3 = Soma(1.5, 8.5, 6.5);
    Console.WriteLine(resultado3); //16,5
  }

  static int Soma(int num1, int num2)
  {
    return num1 + num2;
  }

  static double Soma(double num1, double num2)
  {
    return num1 + num2;
  }

  static double Soma(double num1, double num2, double num3)
  {
    return num1 + num2 + num3;
  }
}