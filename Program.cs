// See https://aka.ms/new-console-template for more information
// Challenge 1
bool amProgrammer = true; // miss match type, so either change the type to string or change "true" into a bool of true or false
int Age = 28; // miss match type, the type is an int but the value is a float. Change either the type or the value
List<string> Names = new List<string>();
Names.Add("Monica"); // Names is a list so this is an incorrect way to add a string to this list. Either change the variable type or add the name using .Add() ex: Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>(); // the type that was set up for this dict was strings for both key and keyValue, so either 
//change the type of the key pairs to <string, int> and change the "0" to a 0 or keep it as double string and change the second 0 to "0" 
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there","0");
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName"; //single quotes are used for char var type in C# so either change the single quotes to double quotes "" or change type and the value to a char value;
// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5}; //since a list is zero-indexed, i needs to be Numbers.Count - 1 to be within the range.
for(int i = Numbers.Count-1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}
// // Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i); // in a foreach loop i will be the value not the index, so in this case the Console.WriteLine is trying to access values that is out of bound for the list.
    // to fix this error just change the console.wl to (i) or alternatively change the foreach loop into a for loop and use i as an index.
}
//Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
// foreach(int num in EvenMoreNumbers)
// {
//     if(num % 3 == 0)
//     {
//         num = 0; // the num in this foreach loop is just the value of the item and can't be reasign this way; easiest way to rewrite this code is to change it into a for loop.
//     }
// }
//========== Rewritten code=========
for(int i = 0; i < EvenMoreNumbers.Count; i++){
    if(EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }
}

// foreach(int num in EvenMoreNumbers){
//     Console.WriteLine(num);
// }

// Challenge 5
// What can we learn from this error message?
// string MyString = "superduberawesome"; // I learned that strings are immutable =)) and that StringBuilder is a thing!
// MyString[7] = "p";

// // Challenge 6
// // Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12) // Next() is exclusive so the result will never be 12 so the console will never print "Hello" so either change the if condition or change the value in Next()
{
    Console.WriteLine("Hello");
}
