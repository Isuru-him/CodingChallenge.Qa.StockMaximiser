# Introduction 
This project is written to validate the retreive and validate the maximum profit someone can earn on a given set of share price list. 

Inside the logic
There are 2 classes and 1 interface

In the business layer, there is a IMaximiser interface with 2 abstract methods 
and another class called Maximiser

Insde that Maximiser class, one of those abstracted methods called profitMax, has been implemented. 

Inside the test layer, there is a test class called UnitTest1.cs
inside that there are two test methods called, validateMaximumProfit and ValidateZeroProfit respectively. Those two classes are used to validate two separate instances where someone can earn a maximum profit and where the maximum profit is zero for a given set of share prices

# Getting Started

ProfitMax() API is called via UnitTest1.cs classes test methods to execute the tests. 

# Build and Test
Build the code and execute the unit tests to run the code. 

# Contribute
This code is written by : Isuru Madanayake


# Note
Program.cs class has not been used for logic creation and execution. 
Max API in the Maximiser.cs class has not been used for logic creation purposes instead profitMax API has been developed. 
