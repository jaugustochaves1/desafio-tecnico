using System;

namespace desafio_tecnico
{
  public class Juros
  {
    public double ValorInicial { get; private set; } = 0.00;
    public double ValorAtualizado { get; private set; } = 0.00;
    public int Meses { get; private set; } = 0;
    public double TaxaDeJuros { get; private set; } = 0.01;

    public Juros() { }

    public Juros(double valorInicial, int meses)
    {
      ValorInicial = valorInicial;
      Meses = meses;
    }

    public void CalcularValorAtualizadoComBaseNaTaxaDeJuros()
    {
      var fatorDeDivisao = ObterFatorDeDivisao(Convert.ToInt32(Math.Floor(Math.Log10(ValorInicial) + 1)));
      ValorAtualizado = Math.Pow(ValorInicial * (1 + TaxaDeJuros), Meses) / fatorDeDivisao;
    }

    private long ObterFatorDeDivisao(int fator)
    {
      int index = 1;
      long fatorDeDivisao = 0;

      while(index <= fator) {
        if(index == 1){
          fatorDeDivisao = 100;
        } else if(index > 3){
          fatorDeDivisao *= 10000;
        } else {
          fatorDeDivisao *= fatorDeDivisao;
        }
        index++;
      }
      
      return fatorDeDivisao;
    }
  }
}