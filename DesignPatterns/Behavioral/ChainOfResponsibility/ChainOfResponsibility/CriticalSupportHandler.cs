namespace ChainOfResponsibility;

public class CriticalSupportHandler : SupportHandler
{    
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Severity == 3)
        {
            Console.WriteLine("Critical Support handled the request.");
        }
        else
        {
            Console.WriteLine("No handler could process the request.");
        }
    }
}
