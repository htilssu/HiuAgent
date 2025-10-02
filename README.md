# HiuAgent - Microsoft Agent Framework Implementation

A Blazor Server application implementing Microsoft Agent Framework for building intelligent conversational AI agents.

## 🏗️ Project Architecture

This solution consists of two main projects:

- **HiuAgent** - Blazor Server web application (.NET 8.0)
- **HiuAgent.Core** - Core agent functionality library (.NET 9.0)

## 📋 Prerequisites

Before running this project, ensure you have the following installed:

- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Visual Studio 2022 or Visual Studio Code
- Git (for cloning the repository)

### Verify Prerequisites

```bash
# Check .NET version
dotnet --version

# Should show 9.0.x or later
```

## 🚀 Quick Start

### 1. Clone the Repository

```bash
git clone <repository-url>
cd HiuAgent
```

### 2. Restore Dependencies

```bash
# Restore NuGet packages for the entire solution
dotnet restore
```

### 3. Build the Solution

```bash
# Build all projects in the solution
dotnet build
```

### 4. Run the Application

```bash
# Navigate to the main web project
cd HiuAgent

# Run the Blazor Server application
dotnet run
```

The application will be available at:
- **HTTPS**: https://localhost:7xxx
- **HTTP**: http://localhost:5xxx

(Exact port numbers will be displayed in the console output)

## 🔧 Development Setup

### Using Visual Studio

1. Open `HiuAgent.sln` in Visual Studio 2022
2. Set `HiuAgent` as the startup project
3. Press F5 to run with debugging, or Ctrl+F5 to run without debugging

### Using Visual Studio Code

1. Open the project folder in VS Code
2. Install the C# extension
3. Open terminal and run:
   ```bash
   dotnet run --project HiuAgent
   ```

### Using JetBrains Rider

1. Open `HiuAgent.sln` in Rider
2. Build and run the solution

## 📦 Dependencies

### Core Dependencies

The project uses several key packages for Microsoft Agent Framework:

#### HiuAgent.Core Project
- `Microsoft.Agents.AI` (1.0.0-preview.251001.3) - Core Microsoft Agent Framework
- `Microsoft.Agents.AI.OpenAI` (1.0.0-preview.251001.3) - OpenAI integration for agents
- `Azure.AI.OpenAI` (2.1.0) - Azure OpenAI service client
- `Azure.Identity` (1.16.0) - Azure authentication

#### HiuAgent Web Project
- `Microsoft.NET.Sdk.Web` - ASP.NET Core Blazor Server framework

## ⚙️ Configuration

### App Settings

Configure the application by editing `appsettings.json` and `appsettings.Development.json`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

### Azure OpenAI Configuration

To use Azure OpenAI services, you may need to add configuration for:

```json
{
  "AzureOpenAI": {
    "Endpoint": "your-azure-openai-endpoint",
    "ApiKey": "your-api-key",
    "DeploymentName": "your-deployment-name"
  }
}
```

**⚠️ Security Note**: Never commit API keys to source control. Use user secrets, environment variables, or Azure Key Vault for production.

### User Secrets (Development)

For development, use .NET user secrets to store sensitive configuration:

```bash
cd HiuAgent
dotnet user-secrets init
dotnet user-secrets set "AzureOpenAI:ApiKey" "your-api-key"
dotnet user-secrets set "AzureOpenAI:Endpoint" "your-endpoint"
```

## 🏃‍♂️ Running in Different Environments

### Development Mode

```bash
dotnet run --environment Development
```

### Production Mode

```bash
dotnet run --environment Production
```

### Specific Configuration

```bash
dotnet run --configuration Release
```

## 🧪 Testing the Application

1. Navigate to the application URL (displayed in console)
2. The default page shows "Hello, world!" welcome message
3. Explore the navigation menu for different features:
   - Home
   - Counter
   - Weather
   - Error handling

## 🛠️ Development Commands

### Build Commands

```bash
# Clean the solution
dotnet clean

# Restore packages
dotnet restore

# Build the solution
dotnet build

# Build in Release mode
dotnet build --configuration Release
```

### Running Commands

```bash
# Run with hot reload (development)
dotnet watch run --project HiuAgent

# Run specific project
dotnet run --project HiuAgent

# Run with specific launch profile
dotnet run --project HiuAgent --launch-profile "Development"
```

## 📁 Project Structure

```
HiuAgent/
├── HiuAgent/                    # Main Blazor Server application
│   ├── Components/              # Blazor components
│   │   ├── Layout/             # Layout components
│   │   └── Pages/              # Page components
│   ├── wwwroot/                # Static web assets
│   ├── Program.cs              # Application entry point
│   └── appsettings.json        # Configuration
├── HiuAgent.Core/              # Core agent library
│   ├── Agent/                  # Agent implementations
│   │   └── ChatAgent.cs        # Main chat agent
│   └── Functions/              # Agent functions (placeholder)
├── HiuAgent.sln                # Solution file
└── global.json                 # SDK version configuration
```

## 🔍 Microsoft Agent Framework Features

This project demonstrates:

- **Agent Implementation**: Core chat agent structure
- **Azure OpenAI Integration**: Direct connection to Azure OpenAI services
- **Blazor Server UI**: Real-time web interface for agent interaction
- **Modular Architecture**: Separation of core agent logic and web presentation

## 🚧 Current Implementation Status

- ✅ Project structure and dependencies
- ✅ Basic Blazor Server application
- ✅ Microsoft Agent Framework packages integrated
- ⏳ Agent functionality implementation (in progress)
- ⏳ Chat interface development
- ⏳ OpenAI integration configuration

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## 📄 License

[Add your license information here]

## 🆘 Troubleshooting

### Common Issues

1. **Build Errors**: Ensure you have .NET 9.0 SDK installed
2. **Port Conflicts**: The application will find available ports automatically
3. **Package Restore Issues**: Run `dotnet restore` in the solution root
4. **Azure OpenAI Errors**: Verify your API keys and endpoint configuration

### Getting Help

- Check the console output for detailed error messages
- Review the application logs in the Logging configuration
- Ensure all prerequisites are properly installed

### Support

For issues specific to Microsoft Agent Framework, refer to the [official documentation](https://docs.microsoft.com/en-us/azure/cognitive-services/openai/).