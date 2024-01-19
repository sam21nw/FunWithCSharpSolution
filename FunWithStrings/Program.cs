using System.Runtime.CompilerServices;

BasicStringFunctionality();
Console.WriteLine();
StringInterpolationWithDefaultInterpolatedStringHandler();

static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic string functionality:");
    string str = "Hello World";
    Console.WriteLine(str);
    Console.WriteLine(str.Contains(" "));
    Console.WriteLine(str.Replace("World", "Dude"));
    Console.WriteLine(str);

    Console.WriteLine(String.Concat("functionality:", " OOPS"));

    Console.WriteLine("Amigos {0}{0}{0}", Environment.NewLine);
    Console.WriteLine("end of line");
}

//  This enables the instance to make an educated guess as to how much memory to allocate. Literals are added in with the AppendLiteral() method, and variables are added in with the AppendFormatted() method. Bench testing has shown a significant performance improvement in string handling in C# 10 when your code contains string interpolation.
static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("=> String interpolation under the covers:\a");
    int age = 4;
    string name = "Soren";

    var builder = new DefaultInterpolatedStringHandler();
    builder.AppendLiteral("Hello");
    builder.AppendFormatted(name);
    builder.AppendLiteral(". You are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");
    Console.WriteLine(builder.ToStringAndClear());
}