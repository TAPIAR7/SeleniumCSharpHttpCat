# SeleniumCSharpHttpCat
This project is pretending to use the basic syntax of a test using C# and Selenium.

What is doing right now?
1. It is open the webpage https://http.cat/
2. Navigate to the first element cat
3. Verifies the 100 Continue header

This code can be reusable thanks to the notation implemented with statusCode, we can do it for all the status codes, and for different header messages.