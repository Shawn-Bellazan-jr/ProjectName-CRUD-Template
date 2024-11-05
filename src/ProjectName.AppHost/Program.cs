var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.ProjectName_Api>("api");

builder.AddProject<Projects.ProjectName_Web>("web")
    .WithReference(api);

builder.Build().Run();
