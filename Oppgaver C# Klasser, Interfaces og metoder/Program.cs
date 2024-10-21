class Program {
  static void Main(string[] args) {
    ICalculator calc = new Calculator();

    double x = calc.TakeDouble("Enter first number: ");
    double y = calc.TakeDouble("Enter second number: ");
    Operation op = calc.TakeOperation("Enter operation: ");

    double res = 0;

    Dictionary<Operation, string> opMap = new Dictionary<Operation, string> {
      { Operation.add, "+" },
      { Operation.sub, "-" },
      { Operation.mul, "*" },
      { Operation.div, "/" },
    };

    switch (op) {
      case Operation.add:
        res = calc.AddNumbers(x, y);
        break;
      case Operation.sub:
        res = calc.SubtractNumbers(x, y);
        break;
      case Operation.mul:
        res = calc.MultiplyNumbers(x, y);
        break;
      case Operation.div:
        res = calc.DivideNumbers(x, y);
        break;
      default:
        // dead code
        Console.WriteLine("Invalid input!");
        break;
    }

    Console.WriteLine("{0} {1} {2} = {3}", x, opMap[op], y, res);
  }
}