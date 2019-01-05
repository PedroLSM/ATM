using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ATM.Test
{
    [TestClass]
    public class CaixaTests
    {
        [TestMethod]
        public void Sacar230()
        {
            Caixa atm = new Caixa();

            string result = atm.Sacar(230);
            // 100, 50, 20, 10, 5, 2
            int[] notas = { 2, 0, 1, 1, 0, 0 };
            bool check = result.Contains("Saque de 230R$ realizado com sucesso:");
            Assert.IsTrue(check);
            CollectionAssert.AreEqual(notas, atm.Qtds);

        }

        [TestMethod]
        public void Sacar18()
        {
            Caixa atm = new Caixa();

            string result = atm.Sacar(18);
            // 100, 50, 20, 10, 5, 2
            int[] notas = { 0, 0, 0, 1, 1, 1 };
            bool check = result.Contains("Apenas foi possivel realizar o saque de 17R$ :");

            Assert.IsTrue(check);
            CollectionAssert.AreEqual(notas, atm.Qtds);

        }
    }
}
