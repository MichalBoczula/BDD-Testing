Feature: GetProductById
    As a user,
    I want to retrieve a product by its ID,
    So that I can view its details.
    
    Scenario: Retrieve a product by its ID <ProductID>
        When the client requests the product by ID 
        Then the API should return a product
        And the product should have properties id, name, and price

          Examples:
        | ProductID |
        | 1         |
        | 2         |


    Scenario: Attempt to retrieve a non-existent product
        When the client requests a product with an invalid ID
        Then  the response should indicate that the product with id -1 does not exist

            Examples:
        | ProductID |
        | 999         |
        | -1         |