Feature: Amazon.in Landing Page UI Verification
    Launch http://amazon.in and page should be loaded.

Scenario: Verify the Amazon Landing Page
  Given I launch the  Amazon Site "http://amazon.in"
  When The Page is loaded
  Then Verify the page