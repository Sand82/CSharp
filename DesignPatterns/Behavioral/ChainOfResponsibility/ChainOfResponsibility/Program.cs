using ChainOfResponsibility;

var basic = new BasicSupportHandler();
var technical = new TechnicalSupportHandler();
var critical = new CriticalSupportHandler();

basic.SetNext(technical);
technical.SetNext(critical);

var requests = new List<Request> {
    new Request { Name = "Base", Value = 1 }, 
    new Request { Name = "Technical", Value = 2 }, 
    new Request { Name = "Critical", Value = 3 }, 
    new Request { Name = "Error", Value = 4 } 
};

foreach (var request in requests)
{
    basic.HandleReqeust(request);
}
