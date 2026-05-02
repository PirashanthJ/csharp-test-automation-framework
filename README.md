# C# QA Automation Framework (Playwright, Selenium, API, BDD)

This repository demonstrates a production-style QA automation framework built using C#. It includes UI automation (Playwright & Selenium), API testing, and BDD using SpecFlow.

The framework is designed for scalability, reliability, and CI/CD integration — reflecting real-world enterprise QA practices.

---

## 🚀 What This Framework Solves

- Reduces regression execution time
- Improves test reliability by minimizing flaky tests
- Enables fast feedback in CI pipelines
- Supports scalable automation across UI and API layers
- Provides clear and maintainable test structure for teams

---

## 🧠 Key Features

- Playwright UI automation (fast & reliable E2E tests)
- Selenium WebDriver support (cross-browser testing)
- API testing using HttpClient
- SpecFlow BDD (Gherkin scenarios)
- Page Object Model (POM) design pattern
- Shared reusable framework components
- Environment-based configuration
- GitHub Actions CI pipeline
- Flaky test reduction strategies

---

## 🔧 Tech Stack

- C# / .NET 8
- Playwright
- Selenium WebDriver
- SpecFlow (BDD)
- NUnit
- GitHub Actions (CI/CD)

---

## 📁 Project Structure
```
csharp-test-automation-framework/
├── src/
│ └── Shared/
│ ├── Api/
│ ├── Pages/
│ └── Configuration/
├── tests/
│ ├── Playwright.Tests/
│ ├── Selenium.Tests/
│ ├── Api.Tests/
│ └── SpecFlow.Bdd.Tests/
│ ├── Features/
│ ├── Steps/
│ └── Hooks/
├── docs/
└── .github/workflows/
```

---

## ▶️ How to Run

### Prerequisites

- .NET 8 SDK installed  
- Chrome / Chromium browser installed  
- Playwright browsers installed  

---

### Install dependencies
dotnet restore

---

### Run all tests
dotnet test


---

### Run specific test suites
dotnet test tests/Playwright.Tests

dotnet test tests/Selenium.Tests

dotnet test tests/Api.Tests

dotnet test tests/SpecFlow.Bdd.Tests


---

## ⚡ Flaky Test Reduction Strategy

Flaky tests reduce trust in automation and slow down delivery.

This framework follows best practices to minimise instability:

- Avoid static waits (e.g. Thread.Sleep)  
- Use condition-based waits  
- Use stable and reliable locators  
- Keep tests independent and isolated  
- Validate business logic via API where possible  
- Capture logs, screenshots, and test artifacts in CI  
- Design tests to be deterministic and repeatable  

The goal is not just passing tests, but producing reliable and actionable results.

---

## 🔄 CI/CD Integration

This framework includes a GitHub Actions pipeline that:

- Restores dependencies  
- Builds the solution  
- Executes all test suites  
- Runs tests in a headless environment  

This enables continuous feedback on every commit or pull request.

---

## 📊 Example Use Cases

This framework can be used for:

- End-to-end UI regression testing  
- API validation and contract testing  
- BDD-driven acceptance testing  
- CI/CD pipeline quality gates  
- Cross-browser test execution  
- Automation strategy scaling  

---

## 🏢 Real-World Context

This project is a simplified representation of frameworks I have built and worked with in professional environments.

It reflects real-world QA automation practices focused on maintainability, reliability, and scalability rather than simple test scripts.

---

## 🤝 Contributing

This is a portfolio project, but contributions and suggestions are welcome.

---

## 📌 Notes

- Sample tests use public demo endpoints and pages  
- In real-world usage, this would integrate with:
  - Test environments  
  - Test data management  
  - Reporting tools (Allure, etc.)  
  - CI quality gates  

## 📸 Example Test Output

Below is a sample representation of how tests are executed and validated across UI, API, and CI/CD layers within this framework.

<img width="1536" height="1024" alt="Example-output" src="https://github.com/user-attachments/assets/28399b26-335b-4dfa-a0cd-4581b31d2b4c" />
