using GrunnleggendeCSharp;

// basic string concatenation
string nameToGreet = "Bjørn";
CSharp.HelloHi(nameToGreet);

// sum of two different number types (method includes conversion to return type)
decimal disparateNumSum = CSharp.AddDifferentNumberTypes();
Console.WriteLine(disparateNumSum);

// addition
double sumOfDoubles = CSharp.BasicAddition(32, 46);
Console.WriteLine(sumOfDoubles);


// no return value
CSharp.DontPrintAnything();


// different numbers for different outcomes
bool sameNumOrNot = CSharp.EqualChecker(42, 42);
Console.WriteLine(sameNumOrNot);

bool isTotalThirty = CSharp.ThirtyOrNot(13, 17);
Console.WriteLine(isTotalThirty);

// same as above, different set of outcomes and stored in double variable
double sumOrProduct = CSharp.SumOrProduct(42, 42);
Console.WriteLine(sumOrProduct);

Console.ReadLine();
