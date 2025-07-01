var builder = DistributedApplication.CreateBuilder(args);

var web = builder.AddProject<Projects.SimpleRest_Web>(ProjectNames.WebApi);

builder.Build().Run();
