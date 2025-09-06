var builder = DistributedApplication.CreateBuilder(args);

var username = builder.AddParameter("username", "postgres");
var password = builder.AddParameter("password", "postgres");

var postgres = builder.AddPostgres("postgres", username, password, port: 5432)
    .WithOtlpExporter();

var appSmith = builder.AddContainer("appsmith", "index.docker.io/appsmith/appsmith-ee")
    .WithBindMount($"{AppHostExtensions.GetRepoRootDir()}/volumes/appsmith/appsmith-stacks", "/appsmith-stacks")
    .WithEndpoint(4200, 80, scheme: "http")
    .WithEndpoint(4201, 443, scheme: "https");

var migrator = builder.AddProject<Projects.Migrator>("migrator").WaitFor(postgres).WithReference(postgres);

var api = builder.AddProject<Projects.Api>("api").WaitForCompletion(migrator).WithReference(postgres);

await builder.Build().RunAsync();
