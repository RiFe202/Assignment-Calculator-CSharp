interface ICalculator {
  double TakeDouble(string prompt);
  Operation TakeOperation(string prompt);
  double AddNumbers(double x, double y);
  double SubtractNumbers(double x, double y);
  double MultiplyNumbers(double x, double y);
  double DivideNumbers(double x, double y);
}

enum Operation {
  add,
  sub,
  mul,
  div,
}

// use docstrings for all methods
class Calculator : ICalculator {
  /// Prompts the user for a double and returns it
  public double TakeDouble(string prompt) {
    Boolean isValid = false;

    while (!isValid) {
      Console.Write(prompt);
      if(double.TryParse(Console.ReadLine(), out double res)) {
        return res;
      } else {
        Console.WriteLine("Invalid input! Try Again: ");
      }
    };

    // dead code
    return 0;
  }

  /// Prompts the user for an operation and returns it
  public Operation TakeOperation(string prompt) {
    Boolean isValid = false;

    while (!isValid) {
      Console.Write(prompt);
      if(Enum.TryParse(Console.ReadLine(), out Operation res)) {
        return res;
      } else {
        Console.WriteLine("Invalid input! Try Again: ");
      }
    };

    // dead code
    return Operation.add;
  }

  /// Adds two numbers
  public double AddNumbers(double x, double y) {
    return x + y;
  }

  /// Subtracts two numbers
  public double SubtractNumbers(double x, double y) {
    return x - y;
  }

  /// Multiplies two numbers
  public double MultiplyNumbers(double x, double y) {
    return x * y;
  }

  /// Divides two numbers
  public double DivideNumbers(double x, double y) {
    return x / y;
  }
}
