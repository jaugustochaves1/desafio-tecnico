using desafio_tecnico;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class JurosTest
    {
        [TestMethod]
        public void Dado_um_objeto_juros_deve_ser_retornado_a_taxa_de_juros_maior_que_zero()
        {
            var juros = new Juros();
            Assert.AreEqual(0.01, juros.TaxaDeJuros);
        }

        [TestMethod]
        public void Dado_um_objeto_juros_sem_informar_o_valor_inicial_e_o_tempo_em_meses_deve_retornar_os_valores_padroes()
        {
            var juros = new Juros();

            Assert.AreEqual(0.00, juros.ValorInicial);
            Assert.AreEqual(0.00, juros.ValorAtualizado);
            Assert.AreEqual(0, juros.Meses);
        }

        [TestMethod]
        public void Dado_um_objeto_juros_com_o_valor_inicial_e_o_tempo_em_meses_maiores_que_zero_deve_calcular_o_valor_atualizado_com_base_na_taxa_de_juros_e_retornar_um_valor_maior_que_zero()
        {
            var juros = new Juros(100, 5);
            juros.CalcularValorAtualizadoComBaseNaTaxaDeJuros();

            Assert.AreNotEqual(0.00, juros.ValorInicial);
        }
    }
}
