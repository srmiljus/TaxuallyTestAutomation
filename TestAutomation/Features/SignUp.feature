Feature: SignUp

Scenario: 01 User successfully finished Sign up
	Given user navigate to login page
	When user click on 'Allow all cookies' button on Manage cookies
	And user click on 'Get started' button
	Then verify user can see 'signup' in URL of the page
	When user choose 'Serbia' from 'Where is your business located?' dropdown
	And user select first option from countries
	And user select 'France' from countries
	And user select all unselected countries
	And user unselect 5 random counties
	And user click on all Help me get a VAT number buttons
	And user proceed with Next step
	Then user verify 'Create account' title
	When user enter details to create account
		| Field       | Value              |
		| FirstName   | TaxuallyFirstName  |
		| LastName    | TaxuallyLastName   |
		| CountryCode | HU                 |
		| PhoneNumber | 22233444566        |
		| YourEmail   | taxually@gmail.com |
		| Password    | Taxually1234@!     |
	Then user click on checkmark to Accept Privacy Policy





	