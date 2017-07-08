---
#   Please see this to see how it works
#
#   https://github.com/Azure/autorest/blob/master/docs/proposals/generator-specific-settings/literate-configuration.md
#
#   To run just do autorest infra.md
#
override-info:
  title: Infra Admin Client
csharp:
    namespace: Microsoft.AzureStack.Infra.Admin
    output-folder: Generated

output-folder: Artifacts

output-artifact: 
    - swagger-document.json


input-file:
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/fabric.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/fabric.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/alerts.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/pools.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/roles.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/scaleunits.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/storage.json"
    - "https://raw.githubusercontent.com/BrianLPeterson/azure-rest-api-specs/feature/azsswagger/AzureStack/arm-fabric-admin/2016-05-01/swagger/update.json"

header-text: MICROSOFT_MIT

azure-arm: true

payload-flatteningthreshold: 2
