using System.Runtime.CompilerServices;
using System.Text;

//BasicStringFunctionality();
//Console.WriteLine();
//StringInterpolationWithDefaultInterpolatedStringHandler();
//Console.WriteLine();
//StringEquality();
//Console.WriteLine();
//StringEqualitySpecifyingCompareRules();
//Console.WriteLine();
//StringsAreImmutable();
//Console.WriteLine();
FunWithStringBuilder();

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
    Console.WriteLine("=> String interpolation under the covers:");
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

static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello";
    string s2 = "Yo!";
    Console.WriteLine(s1.Equals(s2));
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello";
    string s2 = "hello";

    Console.WriteLine($"s1={s1}, s2={s2}{Environment.NewLine}");
    Console.WriteLine("Default rules, s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Ignore case, s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2,
s1.IndexOf("E"));
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\",StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
}

static void StringsAreImmutable()
{
    string s1 = "HELLO";
    Console.WriteLine(s1.Equals(s1.ToLower()));
    Console.WriteLine(s1.CompareTo(s1));
}

// What is unique about the StringBuilder is that when you call members of this type, you are directly modifying the object’s internal character data(making it more efficient), not obtaining a copy of the data in a modified format.
static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new("**** Fantastic Games ****", 256);
    sb.Append('\n');
    sb.AppendLine("Half Life");
    Console.WriteLine(sb.ToString());
    sb.Replace("Life", "Dead");
    Console.WriteLine(sb.ToString());
    Console.WriteLine($"sb has {sb.Length} characters");
}