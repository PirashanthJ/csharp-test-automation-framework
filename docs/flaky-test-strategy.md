# Flaky Test Reduction Strategy

Flaky tests reduce trust in automation. This framework demonstrates patterns that help reduce instability.

## Key Practices

1. **Avoid static waits**
   - Use condition-based waits, network events, or element state checks.

2. **Use stable selectors**
   - Prefer accessible roles, test IDs, and meaningful attributes over brittle CSS paths.

3. **Separate API and UI validation**
   - Validate business rules at API level where possible.
   - Use UI tests for true user journeys only.

4. **Make tests independent**
   - Avoid sharing state between tests.
   - Use fresh data or deterministic test setup.

5. **Capture useful failure evidence**
   - Screenshots, traces, logs, and request/response payloads should be captured in CI.

6. **Treat retries carefully**
   - Retries can reduce noise but should not hide real product issues.
