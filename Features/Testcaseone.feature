Feature: Testcaseone

A short summary of the feature

@tag1
Scenario: Testcaseone
	Given Open site evraz https://evraz.market/
	When Open catalog page
	And Сhoose category
	And Press the button basket
	And Go to basket
	When I see the added item in the cart
	And Click change
	And Add product in basket
	And Click cancellation
	And Click change
	When Add product and save
	And See the change amount
	When Delete item
	And I see a notification window about the absence of goods in the basket
	And Open catalog page
	And Press the button basket
	When I see the added item in the cart
	And Open catalog page
	When Сhoose category
	And Open goods
	And Add product in basket
	When I see the added item in the cart
	And Change region
	And Close message about theoretical weight of metal
	And remove one item
	Then Delete everything
	
