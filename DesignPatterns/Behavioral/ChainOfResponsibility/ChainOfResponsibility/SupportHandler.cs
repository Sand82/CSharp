namespace ChainOfResponsibility;

public abstract class SupportHandler
{
    protected SupportHandler nextHandler;

    public void SetNext(SupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public abstract void HandleRequest(SupportRequest request);
}
