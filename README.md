### Banking Test for Software Engineer In Test
------------------------------------------

We would like the candidate to spend no more than a couple hours of their time on this.
We would like to see test case creation, test data creation, and show how they would trigger the execution of tests with anticipated results.

### Banking System Test

Assume an API to facilitate banking operations, no need to develop a GUI (no need to browser test, etc). Write test cases for the API. 

#### System Design:*

System allows for users and user accounts.

- A user can have as many accounts as they want.

- A user can create and delete accounts.

- A user can deposit and withdraw from accounts.

- An account cannot have less than $100 at any time in an account.

- A user cannot withdraw more than 90% of their total balance from an account in a single transaction.

- A user cannot deposit more than $10,000 in a single transaction.

##### Notes:

We will focus our review on coding style, organization, testability and test coverage.

Don't worry about a real database. Feel free to fake it with in-memory data structures.

The completed work can be returned to us in a zipped/compressed package that we can extract, build and run; or through a public repository such as GitHub.  Please setup the project so that we can run the application locally in a container via Docker Compose.

### Q&A

##### System allows for users and user accounts (= user can log in to user account and create a bank account?)
- We are not concerned about authentication at this time, we have users and users can create multiple accounts
 
##### An account cannot have less than 100 bucks at any time in the account (= user can not create a user account with API -> only in the bank office -> at the time of creating an account at the bank user has to pay 100 bucks as a permanent deposit -> If a user wants to withdraw this untouchable 100 bucks, they have to close a user account, but the same way it was created - at the bank and not with API?)
- The minimum balance for any account is 100, any open account (new or existing) must maintain that 100
 
##### A user cannot withdraw more than 90% of their total balance from an account in a single transaction (= the untouchable amount of 100 bucks included in this assumption or not?)
- This requirement is additional to the 100 minimum, it does not negate it. “