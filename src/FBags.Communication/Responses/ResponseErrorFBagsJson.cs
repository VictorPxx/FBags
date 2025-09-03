namespace FBags.Communication.Responses;
public class ResponseErrorFBagsJson
{
    public List<string> MessagesError { get; set; }

    public ResponseErrorFBagsJson(List<string> messagesError)
    {
        MessagesError = messagesError;
    }

    public ResponseErrorFBagsJson(string messageError)
    {
        MessagesError = [messageError];
    }
}
