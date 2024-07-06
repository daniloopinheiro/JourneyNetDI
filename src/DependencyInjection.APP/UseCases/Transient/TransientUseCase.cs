public class TransientUseCase
{
    public string Execute() 
    { 
        return $"Transient com ID: {Guid.NewGuid()}";
    }
}