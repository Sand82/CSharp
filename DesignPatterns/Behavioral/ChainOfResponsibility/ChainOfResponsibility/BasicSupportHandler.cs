namespace ChainOfResponsibility;

public class BasicSupportHandler : SupportHandler
{  
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Severity == 1)
        {
            Console.WriteLine("Basic Support handled the request.");
        }
        else if(nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}
