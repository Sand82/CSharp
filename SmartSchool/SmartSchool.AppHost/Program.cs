var builder = DistributedApplication.CreateBuilder(args);

var students = builder.AddProject<Projects.SmartSchool_Students>("students");

var bff = builder.AddProject<Projects.SmartSchool_Bff>("bff")
    .WithReference(students);
builder.AddProject<Projects.SmartSchool_Web>("web")
    .WithReference(bff);

builder.Build().Run();
