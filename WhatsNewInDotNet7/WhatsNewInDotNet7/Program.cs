using System.Text.RegularExpressions;

Console.WriteLine("Hello, .NET 7!");

// This new attribute allows you to specify what kind of data a string represents, for example Regex, JSON, or a DateTime.
// This is used to extend syntax highlighting and colorization.
// For example highlighting and colorization already was supported for Regex
var _ = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

// But not for RegexGenerator. (Since I'm in preview 3, it does showed colorized.
// Note: The Test method below, is for illustation purposes. It doesn't do anything.

[RegexGenerator(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase)]
string Test(string text)
{
    return text;
}

// Now JSON strings are colorized.
var json = @"{'employee': {  
                'firstName': 'Joe',   
                'lastName': 'Doe',   
                'salary': 99999,   
                'married': true
                }  
             }";

// Methods just to avoid 'Declared but never used' squiggily lines.
Console.WriteLine(Test("JSON Test"));
Console.WriteLine(json);
