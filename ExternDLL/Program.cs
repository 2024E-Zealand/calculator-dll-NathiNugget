// See https://aka.ms/new-console-template for more information
using CalculatorClassLibrary;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Addition test of 1 + 2: {Calculator.CalculateAddition(1, 2)}");
Console.WriteLine($"Addition test of 1 - 2: {Calculator.CalculateSubtraction(1, 2)}");
Console.WriteLine($"Addition test of 4 / 2: {Calculator.CalculateDivision(4, 2)}");
Console.WriteLine($"Addition test of 4 * 2: {Calculator.CalculateMultiplication(4, 2)}");

char operand = '\0';
int x = 0;
int y = 0;
while (true)
{
    string[] input = Console.ReadLine()!.Split(" ");
    x = int.Parse(input[0]);
    y = int.Parse(input[2]);
    operand = input[1][0];
    string output = operand switch
    {
        '+' => $"Addition test of {x} + {y}: {Calculator.CalculateAddition(x, y)}",
        '-' => $"Subraction test of {x} - {y}: {Calculator.CalculateSubtraction(x, y)}",
        '*' => $"Multiplication test of {x} * {y}: {Calculator.CalculateMultiplication(x, y)}",
        '/' => $"Division test of {x} / {y}: {Calculator.CalculateDivision(x, y)}",
        _ => throw new Exception("Operation not possible")
    };
    Console.WriteLine(output);
    
}