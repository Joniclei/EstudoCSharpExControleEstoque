namespace ContEst
{
  class Produto
  {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValTotal()
    {
      return Preco * Quantidade;
    }

    public void Adic(int qtD)
    {
     Quantidade += qtD;
    }

    public void Sub(int qtD)
    {
      Quantidade -= qtD;
    }




    public override string ToString()
    {

      double preco2 = ValTotal();
      return ($"{Nome} ,{Preco.ToString("C")},{preco2}");
    }


  }
}
