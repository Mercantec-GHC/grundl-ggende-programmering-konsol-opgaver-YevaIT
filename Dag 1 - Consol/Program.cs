// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine('b');
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

string studentName;
studentName = "Bob";

Console.WriteLine($"Student: {studentName}\n");

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write($"Hello, {name}! You have {messages} messages in you inbox. The temperature is {temperature} celsius ");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

Console.WriteLine("\n\n\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

string projectName = "ACME";
string englishVersion = $@"c:\Exercise\{projectName}\data.txt";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianVersion = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

Console.WriteLine($"View English output:\n\t{englishVersion}\n");
Console.WriteLine($"{russianMessage}:\n\t{russianVersion}");

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * 5.0m / 9.0m;

Console.WriteLine($"The temperature is {celsius} Celsius.");