# guidebooks

Azure Subscription:
id: 9adfafa0-83a8-4ed4-84b1-4ac94fd95e9b
name:usa-polel01

Contributor rold creation:
{
  "appId": "4a94bedd-6907-412c-8ede-a8ca7653641f",
  "displayName": "azure-cli-2022-10-21-22-48-19",
  "password": "3XZ8Q~rRqUbl-nDP_gzuwu.lqMHP~kwYz_ybkbXC",
  "tenant": "10ffad8d-c5d4-4b2b-8bca-b55b9898ad7a"
}

Personal access token in AzureDevOps:
ahk3ezu7o7desv623xf4by7qyumtimc3hqjt6hpikxdzcasog4aa

Devops URL:
https://dev.azure.com/polel01

az login
az ad sp create-for-rbac --role="Contributor" --scopes="/subscriptions/9adfafa0-83a8-4ed4-84b1-4ac94fd95e9b"
[System.Environment]::SetEnvironmentVariable('AZDO_PERSONAL_ACCESS_TOKEN','ahk3ezu7o7desv623xf4by7qyumtimc3hqjt6hpikxdzcasog4aa')
[System.Environment]::SetEnvironmentVariable('AZDO_ORG_SERVICE_URL','https://dev.azure.com/polel01')
terraform init -backend-config backend

URL to run the app from Azure: wa-guidebooksapi-dev-f29d.azurewebsites.net