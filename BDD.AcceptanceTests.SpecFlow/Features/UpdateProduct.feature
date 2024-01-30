Feature: UpdateProduct
    As a user,
    I want to update an existing product,
    So that I can modify its details in my product catalog.

    Background:
        Given the product API is available

    Scenario: Update an existing product with valid data
        Given there is an existing product
        When the user updates the product with ID 3 with the following details:
            | Name          | Price   |
            | Updated Name  | 150.0   |
        Then the product with ID 3 should be updated with the new details:
            | Name          | Price   |
            | Updated Name  | 150.0   |

    Scenario: Attempt to update a non-existent product
        When the user attempts to update a product with an invalid ID -11
        Then the response should indicate that there is no product with ID -11

