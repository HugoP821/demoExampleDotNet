Scenario Outline: Login with multiple users
    Given I am on the login page
    When I login with "<salvador>" and "<password>"
    Then I should see "<message>"

Examples:
    | username   | password   | message              |
    | user1      | pass1      | Welcome user1!       |
    | user2      | pass2      | Welcome user2!       |
    | wrongUser  | wrongPass  | Invalid credentials! |
