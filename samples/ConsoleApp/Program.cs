using System.Runtime.InteropServices;

Console.WriteLine($"Hello, world at {DateTime.Now.ToLongTimeString()} on {RuntimeInformation.OSArchitecture}!");

if (args.Length > 0)
{
    Console.WriteLine($"args -- {string.Join(" ", args)}");
}