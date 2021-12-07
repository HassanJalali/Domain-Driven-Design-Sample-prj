using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production.Persistence;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductionDbContext>();
            optionsBuilder.UseSqlServer("server=.;initial catalog =Production_Developer;integrated security=true");
            var c = new ProductionDbContext(optionsBuilder.Options);
            c.DetectEntityMapping();

        }
    }
}

