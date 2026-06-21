using ChainOfResponsibility;

var basic = new BasicSupportHandler();
var technical = new TechnicalSupportHandler();
var critical = new CriticalSupportHandler();

basic.SetNext(technical);
technical.SetNext(critical);

var requests = new List<SupportRequest> {
    new SupportRequest { Name = "Base", Value = 1 }, 
    new SupportRequest { Name = "Technical", Value = 2 }, 
    new SupportRequest { Name = "Critical", Value = 3 }, 
    new SupportRequest { Name = "Error", Value = 4 } 
};

foreach (var request in requests)
{
    basic.HandleReqeust(request);
}
