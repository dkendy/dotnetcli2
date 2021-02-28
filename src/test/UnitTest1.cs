using System;
using Xunit;
using app;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculo c = new Calculo();
            Assert.Equal(c.Resultado(),3);
        }
        //teste
        //modificação feito no feature/ci
        //correção feita em feature/ci
    }
}
