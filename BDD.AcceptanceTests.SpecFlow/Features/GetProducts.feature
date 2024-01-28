Feature: GetProducts
  
 @GetProducts
  Scenario: Get list of projects
        Given the product API is available
        When the client requests the list of products
        Then the API should return a list of products
        And each products should have properties id, name, and price

Examples:
| id  | name             | price |
| 1   | Product One      | 100 |
| 2   | Product Two      | 150 |
| 3   | Product Three | 220 | 
