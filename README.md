#  🖥️ Test Automation Example 🖥️
This repository contains an end-to-end automation testing framework built with C# (.NET).
The goal of this project is to demonstrate advanced QA Automation practices applied to both UI and API testing, showing strong capabilities with the .NET ecosystem.

## Tech Stack
- .NET 8 / C#
- SpecFlow (BDD with Gherkin)
- Selenium WebDriver (UI Testing)
- RestSharp (API Testing)
- xUnit (Test runner)
- Docker + Selenium Grid (Parallel & cross-browser execution)
- Dependency Injection
- Page Object Model (POM)
- appsettings.json + secrets.json (Configuration & secrets management)
- GitHub Actions (CI/CD)

## Project Demonstrates
- ✅ Page Object Model (POM)
- ✅ SpecFlow + Step Definitions (BDD)
- ✅ API Testing with RestSharp
- ✅ Data-Driven Testing (DDT)
- ✅ Configuration with appsettings.json
- 🐳 Parallel Execution with Docker + Selenium Grid
- 🔄 CI/CD with GitHub Actions

🚀 How to Run Locally

Clone the repo:

```
git clone https://github.com/<your-username>/Delinea-Test-Automation.git
cd Delinea-Test-Automation
```
Restore dependencies:
```
dotnet restore
```
Run tests:
```
dotnet test
```
Run in Docker (parallel UI tests):
```
docker-compose up -d
dotnet test
```
Best practices: POM, Dependency Injection, externalized configuration

Combination of UI testing + API testing in one solution

Cross-browser & parallel execution with Docker + Selenium Grid

Continuous Integration (CI/CD) with GitHub Actions
