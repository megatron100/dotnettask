using Hello_Standard_Library_2._1;
Console.WriteLine("Enter name");
string name = Console.ReadLine();
Greeter greeter = new Greeter();
Console.WriteLine(greeter.Greet(name));
