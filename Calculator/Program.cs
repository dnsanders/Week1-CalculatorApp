void CaculatorApp()
{
    Console.WriteLine("Type in the first number followed by the Enter key");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type in the second number followed by the Enter key");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
}

int firstNumber = 0, secondNumber = 0, result = 0, choice = 0;

Console.WriteLine("Type in first number");
    firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in second number");
    secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose and option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Devide");

choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    result = firstNumber + secondNumber;
    Console.WriteLine("Adding {0} and {1} = {2}", firstNumber, secondNumber, result);
}
else if (choice == 2) {
    result = firstNumber - secondNumber;
    Console.WriteLine("Subtracting {0} from {1} = {2}", firstNumber, secondNumber, result);
}
else if (choice == 3) {
    result = firstNumber * secondNumber;
    Console.WriteLine("Multiplying {0} and {1} = {2}", firstNumber, secondNumber, result);
}
else if (choice == 4) 
{
    result = firstNumber / secondNumber;
    Console.WriteLine("Deviding {0} by {1} = {2}", firstNumber, secondNumber, result);
}
else
{
    Console.WriteLine("You did not choose a number between 1-4!");
}

