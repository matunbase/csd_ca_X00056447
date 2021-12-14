Feature: Blood pressure
    A blood pressure reading used to categorise the blood pressure of the patient as low blood pressure, ideal blood pressure, pre-high blood pressure, or high blood pressure.

Scenario: Authenticate Low BP
    Given Diastolic number is 50
    And Systolic number is 80
    When user presses Submit
    Then the screen should display ‘Low blood Pressure’ 

Scenario: Authenticate Ideal BP
    Given Diastolic number is 69
    And Systolic number is 105
    When user presses Submit
    Then the screen should display ‘Ideal blood Pressure’ 

Scenario: Authenticate PreHigh BP
    Given Diastolic number is 84
    And Systolic number is 129
    When user presses Submit
    Then the screen should display ‘PreHigh blood Pressure’

Scenario: Authenticate High BP
    Given Diastolic number is 95
    And Systolic number is 142
    When user presses Submit
    Then the screen should display ‘High blood Pressure’