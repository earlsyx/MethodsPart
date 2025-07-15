

//Methods
// encapsulating code- putting code in 1 spot.
// calling this code in just one line
// allows to reuse our code, 
// call our code more than once
// keeps code simpler ,and cleaner and easier to read.

// pass data into them
// get method data out of them
// gets lots of data out of them

//best practices, DRY - Don't repeat yourself.

//using statement, shortcut,
//text shrotcut.
//ambigious name, ambiguous call. cause problem
using Methods;

// use over and over again
// call method all code in the method is excuted in one line.

//SampleMethods.SayHi();

//if can reduce dont lol
//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

//gettning the value by return a value from a method.
string name = ConsoleMessages.GetUsersName();
ConsoleMessages.SayHi(name); //default, variable name passing.

Console.WriteLine("This is Tim");
ConsoleMessages.SayHi(name);
//code repitition.

//naming is critical, name things for what they do.
// not describe what method it has.
//tells method job

//DRY Don't repeat yourself, important principle
// focus on the logic of things.

// another prinicple SOLID.
// SRP - single responsibility principle
// something should do one thing. one reason to change.
// core method. program.cs , static void main method.
// the idea of each thing has one thing it does.

//repeating logic, not repating 1 line lol
//fixing code requires to change all the same logic.
// 3 lines, 3lines fix.

// instead of fixing in all parts where code is ,
// only have to fi in one stop.
// allows to fix code once, and fixt it everywhere.
// allows to not repeat our code

ConsoleMessages.SayGoodBye();

//making code better. writing in 1 method.
// chungking it in 1 bite. 
// allows you to encapsulate information into a bite size chunk,
// make your application redable. c# is meant to be read by human
// easier to debug, 1 spot, simpler, cleaner. 

//how tocall method, does not reurn value, does not send value.

// method paramters.

double result = MathShortcut.Add(5,3);
Console.WriteLine(result);

double[] vals = new double[] { 2, 5, 6, 21, 52, 89 };
MathShortcut.AddAll(vals);

//returning values from a method

string lastName = Console.ReadLine(); // capturing a string.