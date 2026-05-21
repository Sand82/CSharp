using ChainOfResponsibility;

var basic = new BasicSupportHandler();
var technical = new TechnicalSupportHandler();
var critical = new CriticalSupportHandler();

basic.SetNext(technical);
technical.SetNext(critical);

var request1 = new SupportRequest
{
    Message = "Password reset",
    Severity = 1
};

var request2 = new SupportRequest
{
    Message = "Server bug",
    Severity = 2
};

var request3 = new SupportRequest
{
    Message = "Production outage",
    Severity = 3
};

basic.HandleRequest(request1);
basic.HandleRequest(request2);
basic.HandleRequest(request3);