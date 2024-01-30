Feature: DeleteProduct
    As a user,
    I want to delete an existing product,
    So that I can remove it from my product catalog.

    Background:
        Given the product API is available

    Scenario: Delete an existing product
        Given there is an existing product
        When the user deletes the product with ID 1
        Then the product with ID 1 should be successfully deleted

    Scenario: Attempt to delete a non-existent product
        When the user attempts to delete a product with an invalid ID -1
        Then the response should indicate that the product with ID -1 does not exist
