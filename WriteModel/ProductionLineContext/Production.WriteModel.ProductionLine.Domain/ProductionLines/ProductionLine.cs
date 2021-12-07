using Production.Framework.Core.Domain;
using Production.Framework.Domain;
using Production.WriteModel.ProductionLine.Domain.ProductionLines.Exceptions;

namespace Production.WriteModel.ProductionLine.Domain.ProductionLines
{
    public class ProductionLine : EntityBase , IAggrigateRoot
    {
        protected ProductionLine()
        {

        }
        public ProductionLine(int costCenter, string productionLineTitle)
        {
            SetCostCenter(costCenter);
            SetProductionLineTitle(productionLineTitle);
        }   

        private void SetProductionLineTitle(string productionLineTitle)
        {
            if (string.IsNullOrWhiteSpace(productionLineTitle))
            {
                throw new ProductionLineTitleCantBeNullOrWhiteSpaceException();
            }

            ProductionLineTitle = productionLineTitle;
        }

        private void SetCostCenter(int costCenter)
        {
            if (costCenter != 4)
            {
                throw new CostCenterNumberCantBeLessOrBiggerThan4();
            }

            CostCenter = costCenter;
        }

        public int CostCenter { get ;private set; }
        public string ProductionLineTitle { get;private set; }
    }
}
