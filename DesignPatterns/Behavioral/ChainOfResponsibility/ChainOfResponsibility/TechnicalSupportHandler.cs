namespace ChainOfResponsibility;

public class TechnicalSupportHandler : SupportHandler
{   
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Severity == 2)
        {
            Console.WriteLine("Technical Support handled the request.");
        }
        else if(nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}
