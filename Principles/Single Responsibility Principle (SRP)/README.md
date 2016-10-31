# Single Responsibility Principle (SRP)
A class should have only one reason to change - Uncle Bob

I have created two projects to demonstrate the SRP,
the first 'Violating SRP' has a lottery number generator
interface that defines method to retrieve user input, print
output and a method to generate lottery numbers and display 
them to the user.

The second 'Implementing SRP' separates the concerns of 
user input/output and number generation into distinct interfaces
so that if one concern needs to change, it will not have an
impact on the other.