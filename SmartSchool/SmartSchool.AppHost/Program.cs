var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SmartSchool_Web>("web");

builder.AddProject<Projects.SmartSchool_Students>("smartschool.students");

builder.Build().Run();
