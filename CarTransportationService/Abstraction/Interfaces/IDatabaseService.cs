using CarTransportationService.Request;

namespace CarTransportationService.Abstraction.Interfaces
{
	interface IDatabaseService
    {
        CalculationModel ConstructCalculationModel(UserRequest userRequest);
    }
}
