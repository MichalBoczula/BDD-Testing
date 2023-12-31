Feature: GetProducts
  
 @GetProducts
  Scenario: Get list of projects
        Given the project API is available
        When the client requests the list of projects
        Then the API should return a list of projects
        And each project should have properties id, name, and price

Examples:
| id  | name             | price |
| 1   | Project One      | 100 |
| 2   | Project Two      | 150 |
| 3   | Another Project  | 0 | # Incorrect value
