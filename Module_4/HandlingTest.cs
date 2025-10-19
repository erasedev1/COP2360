using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        string firstNum = Console.ReadLine();

        Console.WriteLine("Enter another number: ");
        string secondNum = Console.ReadLine();

        Console.WriteLine(Divide(firstNum, secondNum));
    }

    static string Divide(string a, string b)
    {
        try
        {
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int e = c / d;
            return $"{c} / {d} = {e}";
        }
        catch (FormatException ex)
        {
            return $"Error: One or both of the inputs are not valid integers.\n Detailed error message: {ex.Message}";
        }
        catch (DivideByZeroException ex)
        {
            return $"Error: Division by zero is not allowed. \n Detailed error message: {ex.Message}";
        }
        catch (OverflowException ex)
        {
            return $"Error: One input is too large. \n Detailed error message: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Error: An unexpected error occurred. \n Detailed error message: {ex.Message}";
        }
    }
}
