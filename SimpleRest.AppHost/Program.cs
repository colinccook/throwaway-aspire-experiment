var builder = DistributedApplication.CreateBuilder(args);

var web = builder.AddProject<Projects.SimpleRest_Web>("webapi");

builder.Build().Run();
