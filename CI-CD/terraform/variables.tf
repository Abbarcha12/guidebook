# TODO: determine best practices for this; consider hard-coding product name to avoid accidental overwriting of resources
variable "product_name" {
  default     = "guidebooks"
  description = "Name of overall product."
  type        = string
}

variable "webapp_name" {
  default     = "guidebooksapi"
  description = "Name of main web application."
  type        = string
}

variable "resource_group_location" {
  description = "Location of the resource group."
  type        = string
}

variable "failover_location" {
  description = "Failover location."
  type        = string
}

variable "env_region" {
  description = "Company region e.g. usa, aus, eu."
  type        = string
}

variable "env_purpose" {
  description = "What this environment will be used for."
  type        = string
}