# MyAI
Project intended to experiment with Dev Containers, .Net Aspire, Azure Developer CLI, and AI tooling

## Build Aspire manifest
cd ./src/MyAI.AppHost
dotnet run --project AppHost.csproj --output-path manifest.json --publisher manifest

## Generate bicep from Aspire project
azd config set alpha.infraSynth on
azd infra synth

## Delete resource group
az group delete --name <your-resource-group-name>

## Other azd commands
| azd command | Description |
|-------------|-------------|
| azd env new | Create new environment |
| azd up      | Provisions and Deploys |
| azd povision | Provisions the environment |
| azd deploy   | Deploys the applications |
| azd down    | Clean up resources |