using Production.Framework.Core.ApplicationService;
using Production.WriteModel.ProductionLine.Domain.ProductionLines.Services;
using Production.WriteModel.ProductionLineContext.AppSer.Contract.ProductionLines;

namespace Production.WriteModel.ProductionLineContext.AppService.ProductionLines
{
    public class CreateProductionLineComandHandler : ICommandHandler<CreateProductionLineComand>
    {
        private readonly IProductionLineRepository _repository;

        public CreateProductionLineComandHandler(IProductionLineRepository repository)
        {
            _repository = repository;
        }

        public void Execute(CreateProductionLineComand command)
        {
            var productionLine = new Production.WriteModel.ProductionLine.Domain.ProductionLines
                                                          .ProductionLine(command.CostCenter,
                                                           command.ProductionLineTitle);


            _repository.Create(productionLine);
        }
    }
}
