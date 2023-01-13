// See https://aka.ms/new-console-template for more information
Calculator calculator = new();

class Calculator {
  int firstNumber = 0;
  int secondNumber = 0;
  string? operation = "";

  public Calculator() {
    Start();
  }
  public void Start() {
    Console.WriteLine("Введите первое число:");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите операцию:");
    operation = Console.ReadLine();

    Calculate();
  }
  private void Calculate() {
    switch(operation) {
      case "+":
        SayResult(firstNumber + secondNumber);
        break;
      case "-":
        SayResult(firstNumber - secondNumber);
        break;
      default:
        Console.WriteLine("Какая то хня");
        break;
    }
    Console.WriteLine();
    Start();
  }

  private void SayResult(int result) {
    Console.WriteLine($"Результат = {result}");
  }
}