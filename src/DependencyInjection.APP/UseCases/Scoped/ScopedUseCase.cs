public class ScopedUseCase 
{
    public string Execute()
    {   
       return $"Scoped com ID: {Guid.NewGuid()}"; 
    }
}