// 2) Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.
// 3) Write a C# Sharp program to print the sum of two numbers.
// 4) Write a C# Sharp program to print the result of dividing two numbers.

//declare basic datatypes
using System;

double passingTouchdowns = 28.00;
int passingYards = 4188;
int rushingYards = 1784;
float yardsGainedPerPass = 6.3f;
decimal yardsGainedPerRush= 4.3m;


Console.WriteLine("Below are statistics from the Kansas City Chiefs 2023-24 Season");
//print a max and min of the values

Console.WriteLine("The total season passing yards: " + passingYards);
Console.WriteLine("The total season rushing yards: " + rushingYards);
Console.WriteLine("The min is:" + Math.Min(passingYards, rushingYards));
Console.WriteLine("The min is:" + Math.Max(passingYards, rushingYards));

//Print the sum of two numbers
Console.WriteLine("The total Kanasas City Chiefs passing and rushing yards was: " + (passingYards+rushingYards));

// divide two numbers
double avgPassingYardsToTouchdowns = passingYards / passingTouchdowns;
Console.WriteLine("The average passing yards needed per passing touchdown is: " + avgPassingYardsToTouchdowns + " yards");

//additional information to utilize float and decimal numbers
Console.WriteLine(); //added for spaces
Console.WriteLine("the average yards gained per pass was " + yardsGainedPerPass + " and the average yards gaind per rush was " + yardsGainedPerRush);