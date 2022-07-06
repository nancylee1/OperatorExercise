//Exercise 1:
//Create a simple program named OperatorExercise in your repos folder to write out the results of addition, subtraction, multiplication, division, and modulus operations.
//For division, create two integer variables called a and b.
////Create a third integer variable and name it quotient (the result of a division) that stores the result of the division of a and b, and another integer variable named remainder that stores the remainder (using the % operator). Write out the results using Console.WriteLine or Console.Write to write out the results in the following form: if a = 17 and b = 4, print the following:
//The result should say: 17 / 4 is 4 remainder 1

using OperatorExercise;

int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;

//Exercise 2:

Console.WriteLine($"{a} / {b} is {b} remainder {remainder}");
Console.WriteLine("What is the radius of your circle?");
var radius = double.Parse(Console.ReadLine());
Console.WriteLine($"The area of a circle with radius of {radius} is {Method.AreaOfCircle(radius)}.");