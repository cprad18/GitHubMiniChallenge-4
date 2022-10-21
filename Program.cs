//Christopher Prado 
//Date Revised: 21OCT22
//Mini Challenge #4
//We are creating an application to see if the first number would be >,<, or = to 
//the second number 
//We will be utilizing the 'if else' statement & converting string ---> integer technique 
//need to update with #datavalidation and #whileLoop 
//Peer Review: Unable to secure a peer review (no one available)

Console.Clear();

Console.WriteLine(" Good Afternoon! Lets play a game I will tell you whether the first number is greater than the other");

Console.WriteLine("");

string num1 = Console.ReadLine();
int numOne = Convert.ToInt32(num1);

Console.WriteLine("Please, enter the second number");
string num2 = Console.ReadLine();
int numTwo = Convert.ToInt32(num2);

if ( numOne > numTwo){
    Console.WriteLine("The second number mentioned is larger than the first");

}else{
    Console.WriteLine("The second number is larger than the first");

} 

Console.WriteLine("I hope you had fun doing that! On this go around lets try to find out if the first number is greater or less than or equal to");

string num3 = Console.ReadLine();
int numThree = Convert.ToInt32(num3);

Console.WriteLine("and the next?");
string num4 = Console.ReadLine();
int numFour = Convert.ToInt32(num4);

if(numThree >= numFour){
    Console.WriteLine("The first number is greater or equal compared to the second number");

}else{
    Console.WriteLine("the second number you entered is greater or equal");
} 
