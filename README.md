# C# Test Automation Framework

A clean portfolio-style C# automation framework demonstrating UI automation, API testing, framework design, and CI/CD practices.

This repository is intentionally structured as a sample automation framework that shows how I approach scalable and maintainable testing for modern applications.

## What This Demonstrates

- Playwright UI automation with C#
- Selenium WebDriver UI automation with C#
- REST API testing with typed clients
- Shared configuration and reusable utilities
- Explicit wait strategies to reduce flaky tests
- CI/CD integration using GitHub Actions
- Clean separation between UI, API, and shared layers

## Repository Structure

```text
csharp-test-automation-framework/
  src/
    Shared/
    Ui.Playwright.Tests/
    Ui.Selenium.Tests/
    Api.Tests/
  docs/
    framework-architecture.md
    flaky-test-strategy.md
  .github/
    workflows/
      test.yml
  README.md
```

## Projects

| Project | Description |
|---|---|
| `Shared` | Common settings and test utilities |
| `Ui.Playwright.Tests` | Playwright examples using page objects and reliable selectors |
| `Ui.Selenium.Tests` | Selenium examples using explicit waits and page objects |
| `Api.Tests` | REST API tests using `HttpClient`, typed models, and assertions |

## Tech Stack

- C# / .NET 8
- NUnit
- Playwright for .NET
- Selenium WebDriver
- FluentAssertions
- GitHub Actions

## Design Principles

### 1. Maintainability
Tests are split by responsibility. Page objects and API clients hide implementation details so tests remain readable.

### 2. Reliability
The framework avoids hard-coded sleeps and uses explicit waits, stable locators, and deterministic assertions.

### 3. Scalability
Projects are separated so UI and API tests can grow independently while sharing configuration and utilities.

### 4. CI Readiness
A GitHub Actions workflow is included to demonstrate build and test execution in a pipeline.

## How to Run Locally

### Prerequisites

- .NET 8 SDK
- Chrome browser for Selenium tests

### Restore and Build

```bash
dotnet restore
dotnet build
```

### Install Playwright Browsers

```bash
dotnet tool install --global Microsoft.Playwright.CLI
playwright install
```

### Run All Tests

```bash
dotnet test
```

### Run API Tests Only

```bash
dotnet test src/Api.Tests/Api.Tests.csproj
```

### Run Playwright Tests Only

```bash
dotnet test src/Ui.Playwright.Tests/Ui.Playwright.Tests.csproj
```

### Run Selenium Tests Only

```bash
dotnet test src/Ui.Selenium.Tests/Ui.Selenium.Tests.csproj
```

## Environment Configuration

The framework supports environment variables for configuration:

| Variable | Purpose | Default |
|---|---|---|
| `BASE_URL` | UI application URL | `https://example.com` |
| `API_BASE_URL` | API base URL | `https://jsonplaceholder.typicode.com` |
| `TIMEOUT_SECONDS` | Default wait timeout | `30` |
| `HEADLESS` | Browser headless mode | `true` |

Example:

```bash
BASE_URL=https://example.com API_BASE_URL=https://jsonplaceholder.typicode.com dotnet test
```

## Flaky Test Reduction Approach

This framework demonstrates the following practices:

- Use explicit waits instead of static sleeps
- Use stable locators and page abstractions
- Keep tests independent and deterministic
- Push validation to API level where UI is not required
- Capture useful pipeline output for debugging

See [`docs/flaky-test-strategy.md`](docs/flaky-test-strategy.md) for more details.

## CI/CD

The included GitHub Actions workflow:

1. Restores dependencies
2. Builds the solution
3. Installs Playwright browsers
4. Runs API tests
5. Runs Playwright tests
6. Runs Selenium tests

Workflow file: [`.github/workflows/test.yml`](.github/workflows/test.yml)

## Notes

This is a sample portfolio repository and uses public demo sites/APIs. In a real client environment, the same framework structure can be adapted for authenticated applications, test data setup, database validation, reporting, and release quality gates.
