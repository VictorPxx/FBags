namespace FBags.Exception.ExceptionBase;
public class ValidationError : FBagsException
{
    public List<string> Errors { get; set; }

    public ValidationError(List<string> messageError)
    {
        Errors = messageError;
    }
}
