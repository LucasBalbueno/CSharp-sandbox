namespace LifeCycles.Services;

public class SecondOperation
{
    private readonly FirstOperation _firstOperation;

    public SecondOperation(FirstOperation firstOperation)
        => _firstOperation = firstOperation;
    
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid FistOperationID => _firstOperation.Id;
}