# SeleniumCSharpHttpCat
This project is pretending to use the basic syntax of a test using C# and Selenium.

## What is doing right now? 
It is performing three basic tests.

### TestClickOn100Cat:
1. It is open the webpage https://http.cat/
2. Navigate to the first element cat 100
3. Verifies the "100 Continue" header

### TestClickOn101Cat:
1. It is open the webpage https://http.cat/
2. Navigate to the first element cat 101
3. Verifies the "101 Switching Protocols" header

### TestReturnHome:
1. It is open the webpage https://http.cat/
2. Navigate to the first element cat 100
3. Verifies the "100 Continue" header
4. Return to home
5. Verifies the "Usage:" header to verify that right now we are on home

Note: This is an example where it is performing test TestClickOn100Cat and returning to home test, in this particular case we can dismiss first test (TestClickOn100Cat), because it is verfied as well in this step or we can test 102 status code as well.

This code can be reusable thanks to POM design pattern implemented with statusCode, we can do it for all the status codes, and for different header messages.