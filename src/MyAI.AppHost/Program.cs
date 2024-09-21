var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MyAI_ApiService>("apiservice");

builder.AddProject<Projects.MyAI_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
