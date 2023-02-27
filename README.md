# Assignment-cloudQA

In this program, we use Selenium to automate the following steps:

1) Navigate to the page using ChromeDriver.
2) Locate and fill the "First name" field using its name attribute.
3) Locate and fill the "Last name" field using its name attribute.
4) Locate and select the "Gender" radio button using its type and value attributes.
5) Submit the form using the submit button's type attribute.

To make the program more robust to changes in the HTML, we've used specific attributes (name, type, and value) to locate the form elements, rather than relying on their position or other properties that may change. This should ensure that the program can continue to function even if the page layout is modified.
