public class SingletonUseCase
{
    public string Execute() 
    { 
        return $"Singleton com ID: {Guid.NewGuid()}";
    }
}