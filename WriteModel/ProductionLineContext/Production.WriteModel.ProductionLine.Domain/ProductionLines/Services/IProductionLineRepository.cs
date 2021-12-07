using Production.Framework.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.WriteModel.ProductionLine.Domain.ProductionLines.Services
{
   public interface IProductionLineRepository : IRepository
    {
        void Create(Production.WriteModel.ProductionLine.Domain.ProductionLines.ProductionLine productionLine);
    }
}
