using CarTransportationService.Request;

namespace CarTransportationService.Abstraction.Interfaces
{
	interface ICalculationService
    {
        float Calculate(CalculationModel calculationModel);
    }
}
