# Create and deploy a microservice using DevOps

# Pre-requisities & DevOps tools
    - VS Code (.Net 6.0)
    - GitHub Account
    - Dockerr Desktop
    - DockerHub Account
    - Azure DevOps Account
    - Azure Account
    - Azure CLI
    - PowerShell
    - Terraform
    - kubectl

# Steps:

    1 - Create a .NetCore project & unit test project
    2 - Build and Run the projects
    3 - Create a GitHub repository
    4 - Push the code to GitHub repository
    5 - Docokerize application (Create docker image)
        - create dockerfile
        - build and run docker image       
        - Push image to docker hub
    6 - Automate build and unit test
        - Create an Azure DevOps project 
        - Crate a YAML pipeline (CI Pipeline)
        - Add a PR stage 
        - Add build task
        - Add unit test task
    7 - Automate docker build and docker push 
        - Crate CI stage
        - Add a PR stage 
        - Add build task
        - Add unit test task
        - Add docker build task
        - Add docker push task
        - 
    8 - Provision Infrastructure         
        - Azure Portal
        - Command and Scripts 
            - Cloud Shell
            - PowerShell
            - CLI
            - ARM template
            - Terraform
        - IaC (YAMAL code)
            - Pipeline with ARM templae
            - Pipeline with Terraform
    9 - Automate deployment (CD Pipeline)
        - deployement to Development environment


# dotnet
    dotnet new 
    dotnet restore 
    dotnet build   
    dotnet run
    .\run-tests.bat 

# Git
    git branch
    git checkout -b feature

# Docker
    docker build -t webapp .
    docker run -p 5000:80 [image-id]
    docker push [docker-user]/[image-name]:v1





# Connect to your Azure account
Connect-AzAccount

# Specify the resource group and AKS cluster name
$resourceGroupName = "your-resource-group"
$clusterName = "your-aks-cluster"

# Set the desired AKS cluster configuration
$aksConfig = New-AzAksClusterConfig `
    -ResourceGroupName $resourceGroupName `
    -Name $clusterName `
    -Location "your-location" `
    -KubernetesVersion "1.20.7" `
    -NodeCount 3 `
    -NodeVmSize "Standard_D2s_v3" `
    -ServicePrincipalClientId "your-client-id" `
    -ServicePrincipalClientSecret "your-client-secret"

# Create the AKS cluster
New-AzAksCluster -ResourceGroupName $resourceGroupName -Name $clusterName -AksClusterConfig $aksConfig

# Install required modules if not already installed
Install-Module -Name Az -AllowClobber -Force

# Connect to your Azure account
Connect-AzAccount

# Set the desired values for the AKS cluster
$resourceGroupName = "myResourceGroup"
$clusterName = "myAKSCluster"
$nodeCount = 3
$nodeVMSize = "Standard_DS2_v2"
$location = "eastus"

# Create the AKS cluster
New-AzAksCluster -ResourceGroupName $resourceGroupName -Name $clusterName -NodeCount $nodeCount -NodeVmSize $nodeVMSize -Location $location
