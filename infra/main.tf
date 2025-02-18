provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "rg" {
  name     = "expense-tracker-rg"
  location = "West Europe"
}

resource "azurerm_cosmosdb_account" "db" {
  name                = "expense-tracker-cosmos"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  offer_type          = "Standard"
  kind                = "GlobalDocumentDB"

  consistency_policy {
    consistency_level = "Session"
  }

  geo_location {
    location          = azurerm_resource_group.rg.location
    failover_priority = 0
  }
}
