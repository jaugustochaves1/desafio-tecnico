using Microsoft.AspNetCore.Mvc;

namespace desafio_tecnico.Controllers
{
  [ApiController]
  [Route("v1")]
  public class JurosController : ControllerBase
  {
    public JurosController()
    {
    }

    [HttpGet]
    [Route("calculajuros/{valorInicial:double}/{meses:int}")]
    public string CalcularJuros(double valorInicial, int meses)
    {
      var juros = new Juros(valorInicial, meses);
      juros.CalcularValorAtualizadoComBaseNaTaxaDeJuros();

      return juros.ValorAtualizado.ToString("0.00");
    }

    [HttpGet]
    [Route("taxaJuros")]
    public double ExibirTaxaDeJuros()
    {
      return new Juros().TaxaDeJuros;
    }
  }
}
