//This is a comment to my code

//rakendus küsib kasutajalt, et ta sisestaks oma nime
//rakendus tervitab kasutajad nimepidi

Console.WriteLine("Enter your name:"); //Output
//string - sõna
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello"+ ", " + userName + "!"); //Output
//string interpolation

Console.WriteLine($"Hello, {userName}!"); //Output