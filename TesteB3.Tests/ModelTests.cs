using TesteB3.Models;

namespace TesteB3.Tests
{
    /// <summary>
    /// Testes unitarios dos calculos de CDB
    /// calculo utilizado VF = VI x [1 + (CDI x TB)]
    /// VF = 20000 x [ 1 + ( 0.009 * 1.08 )]
    /// VF = 20000 x [ 1 +  0,00972 ]
    /// VF = 20000 x 1,00972
    /// VF = 20.194,4
    /// o valor bruto do primeiro mes adotado para validação é 20.194.4
    /// </summary>
    [TestClass]
    public class ModelTests
    {

        private readonly CdbModel _cdbModel;


        public ModelTests()
        {
            _cdbModel = new CdbModel(10000, 0.9, 108, 2);
        }

        //A API deve receber um valor monetario positivo
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Um Valor inicial invalido foi aceito")]
        public void ValorMonetarioÉPositivo()
        {
            var cdb = new CdbModel(0, 0.9, 108, 1);
            Assert.IsTrue(cdb.ValorInicial == 0);
        }

        //A API deve receber um prazo em meses maior que 1 para resgate da aplicação
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Uma quantidade de meses invalida foi aceita")]
        public void OPrazoEmMesesÉMaiorQueUm()
        {
            var cdb = new CdbModel(10000, 0.9, 108, 1);
            Assert.IsTrue(cdb.Meses == 1);
        }

        [TestMethod]
        public void oValorBrutoDoInvestimentoEstaCorreto()
        {
            //R$ 10.195,34
            Assert.AreEqual(10195.34, Math.Round(_cdbModel.ValorFinal,2));
        }

        [TestMethod]
        public void oValorLiquidoDoInvestimentoEstaCorreto()
        {
            // R$10.151,39
            Assert.AreEqual(10151.39, Math.Round(_cdbModel.ValorLiquido,2));
        }

        [TestMethod]
        public void oValorDoGanhoEstaCorreto()
        {
            //R$ 195.34
            Assert.AreEqual(195.34, Math.Round(_cdbModel.Ganho,2));
        }

        [TestMethod]
        public void oCalculoDeCdbEstaCorreto()
        {
            //R$ 10.097.20 
            Assert.AreEqual(10097.20, Math.Round(_cdbModel.Calculate(10000),2));
        }

    }
}
