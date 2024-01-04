# Configure the Azure provider
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.0"
    }
    azuredevops = {
      source  = "microsoft/azuredevops"
      version = ">=0.1.0"
    }
  }

  backend "azurerm" {}

  required_version = ">= 1.1.0"
}

provider "azurerm" {
  features {}
}

provider "azuredevops" {
  org_service_url = "https://dev.azure.com/polel01"
}

resource "random_id" "rid" {
  byte_length = 2
}

resource "azurerm_resource_group" "rg" {
  name     = "rg-${var.product_name}-${var.env_purpose}-${var.env_region}-${random_id.rid.hex}"
  location = var.resource_group_location
}

resource "azurerm_user_assigned_identity" "uai" {
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location

  name = "uai-${var.product_name}-${var.env_purpose}-${random_id.rid.hex}"
}

resource "azurerm_service_plan" "sp_app_service" {
  name                = "sp-${var.webapp_name}-${var.env_purpose}-${random_id.rid.hex}"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  os_type             = "Windows"
  sku_name            = "F1"
}

resource "azurerm_windows_web_app" "wa" {
  name                = "wa-${var.webapp_name}-${var.env_purpose}-${random_id.rid.hex}"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_service_plan.sp_app_service.location
  service_plan_id     = azurerm_service_plan.sp_app_service.id

  site_config {
    always_on = false
  }

  logs {
    application_logs {
      file_system_level = "Verbose"
    }
    http_logs {
      file_system {
        retention_in_days = 7
        retention_in_mb   = 100
      }
    }
    detailed_error_messages = "true"
    failed_request_tracing  = "true"
  }

  identity {
    type         = "UserAssigned"
    identity_ids = [azurerm_user_assigned_identity.uai.id]
  }
}