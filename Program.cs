Calculator calculator = new();

class Calculator {
  string? expression = "";
  Stack<string> stack = new(); 

  public Calculator() {
    Start();
    GetExpression();
    ParseExpression();
    CalculateResult();
  }

  private void Start() {

    Console.WriteLine("Калькулятор/n"+ 
                      "Введите выражение:");
  }
  private void GetExpression() {
    this.expression = Console.ReadLine();


  }

  private void ParseExpression() {
    this.expression.Trim();
    this.expression.Replace(" ","");
    for (int i=0; i < this.expression.Length; i++) {
      Console.WriteLine(this.expression[i]);
    }
  }

  private void CheckSymbol(string symbol) {
    
    try {
      Convert.ToInt32(symbol);

      if (stack.Count > 0) {
        string numberInStack = stack.Pop();
        stack.Push(numberInStack + symbol);
      } else {
        stack.Push(symbol);
      }

    } catch {
      stack.Push(symbol);
    }
  }

  private void CalculateResult() {
    
  }

  private void CheckProcessSymbol(string symbol) {
    switch (symbol) {
      case "+": 
        break;
      case "-":
        break;
      default:
        break;
    }
  }
}