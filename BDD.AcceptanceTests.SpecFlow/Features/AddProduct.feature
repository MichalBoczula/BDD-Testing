Feature: AddProduct
    As a user,
    I want to add a new product,
    So that I can include it in my product catalog.

    Background:
        Given the product API is available

    Scenario: Add a new product with valid information
        When the user adds a new product with the following details:
            | Name          | Price   |
            | New Product   | 100.0   |
        Then the product should be added successfully

    Scenario: Attempt to add a new product with invalid information
        When the user attempts to add a new product with the following details:
            | Name          | Price   |
            | Invalid       | -10.0   |
        Then the response should indicate that the input is invalid