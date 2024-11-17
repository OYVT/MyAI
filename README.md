# MyAI
Experimentation playground for:
- Dev Containers
- .Net Aspire
- Azure Developer CLI
- AI tooling

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

## Configure Development SSL certificate in host/local

# Execute in Windows host
dotnet dev-certs https --export-path ./aspnetapp.pfx --password password
dotnet dev-certs https --trust
# Restart Windows host

# Copy .pfx file to Linux container at /home/vscode

# Execute in Linux container
cd /home/vscode
dotnet dev-certs https --clean --import ./aspnetapp.pfx --password password
dotnet dev-certs https --trust
# Restart container app
