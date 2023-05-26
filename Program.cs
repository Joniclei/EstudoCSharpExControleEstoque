using System;
using System.Globalization;

namespace ContEst
{
  public class Program
  {
    public static void Main(string[] args)
    {

      Produto p = new Produto();

      Console.WriteLine("Entre com os dados do produto");
      Console.Write("Nome: "
);
p.Nome = Console.ReadLine();

      Console.Write("Preco :");
      p.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantidade no estoque");
      p.Quantidade = Convert.ToInt32(Console.ReadLine(),CultureInfo.InvariantCulture);

      Console.WriteLine();
      Console.WriteLine($"Dados do Produto : {p}");

      Console.WriteLine("Digite a quantidade de produtos para ser adicionado");
      int qtP = Convert.ToInt32(Console.ReadLine(), CultureInfo.InstalledUICulture);

      p.Adic(qtP);

      Console.WriteLine($"Somou o produto {p}");

      Console.WriteLine("Digite a quantida que queira diminuir");
      int qtD = Convert.ToInt32(Console.ReadLine(),CultureInfo.InstalledUICulture);

      p.Sub(qtD);

      Console.WriteLine($"Diminuiu o produto {p}");

    }
  }
}
