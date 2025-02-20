namespace LifeCycles.Services;

public class ThirdOperation
{
    private readonly FirstOperation _firstOperation;
    private readonly SecondOperation _secondOperation;
    private readonly SecondOperation _secondOperationNewInstance;

    public ThirdOperation(FirstOperation firstOperation, SecondOperation secondOperation,
        SecondOperation secondOperationNewInstance)
    {
        _firstOperation = firstOperation;
        _secondOperation = secondOperation;
        _secondOperationNewInstance = secondOperationNewInstance;
    }

    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid FirstOperationId => _firstOperation.Id;

    public Guid SecondOperationId => _secondOperation.Id;

    public Guid SecondOperationNewInstanceId => _secondOperationNewInstance.Id;
}