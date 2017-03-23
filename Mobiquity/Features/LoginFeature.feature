Feature: LoginFeature

@login
Scenario Outline: Login/Logout with valid creadentials
	Given Login page is loaded
	When '<email>' and '<password>' are entered and login button pressed
	Then User is successfully logged in
	And User can logout

Examples: 
	| email                      | password |
	| somemail@gmail.com         | password |
	| email.with.dots@gm.ail.com | password |

@login
Scenario Outline: Login with invalid creadentials
	Given Login page is loaded
	When '<email>' and '<password>' are entered and login button pressed
	Then User sees error message

Examples: 
	| email                            | password |
	| invalidmail1                     | password |
	| invalidmail2@.com                | password |
	| invalidmail3@gmail               | password |
	| invalidmail4!#$%^&*()_@gmail.com | password |
