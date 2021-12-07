using Microsoft.EntityFrameworkCore;
using Production.Framework.Core.Persistence;
using Production.Framework.Persistence;
using Production.WriteModel.ProductionLine.Domain.ProductionLines.Services;

namespace Production.WriteModel.ProductionContext.Infrastructure.ProductionLines
{
    public class ProductionLineRepository : RepositoryBase<Production.WriteModel.ProductionLine.Domain.ProductionLines.ProductionLine>, IProductionLineRepository
    {
        public ProductionLineRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public void Create(ProductionLine.Domain.ProductionLines.ProductionLine productionLine)
        {
            base.Create(productionLine);
        }
    }
}
