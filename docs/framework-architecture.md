# Framework Architecture

This repository demonstrates a modular C# test automation approach covering UI and API validation.

## Design Principles

- **Separation of concerns**: UI, API, and shared utilities are separated into different projects.
- **Maintainability**: Page objects and API clients encapsulate implementation details.
- **Reliability first**: Tests avoid static sleeps and use explicit/event-based waits.
- **Configuration by environment**: Test URLs and runtime settings are controlled through environment variables.
- **CI-ready**: The repository includes a GitHub Actions workflow for repeatable execution.

## Projects

| Project | Purpose |
|---|---|
| `Shared` | Common settings and utilities |
| `Ui.Playwright.Tests` | Modern browser automation examples using Playwright |
| `Ui.Selenium.Tests` | Selenium WebDriver examples with explicit waits |
| `Api.Tests` | REST API validation examples using typed API clients |

## Recommended Extension Points

- Add test data builders for complex user journeys.
- Add reporting through Allure, ReportPortal, or NUnit TRX artefacts.
- Add tagged smoke/regression suites for release pipelines.
- Add Docker-based test execution for consistent environments.
