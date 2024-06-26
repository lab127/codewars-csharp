/**
Your task is to create a function that does four basic mathematical operations.

The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.

Examples(Operator, value1, value2) --> output
('+', 4, 7) --> 11
('-', 15, 18) --> -3
('*', 5, 5) --> 25
('/', 49, 7) --> 7
*/
class BasicMathOps
{
    public static double BasicOp(char operation, double value1, double value2)
    {
        double result;
        switch (operation)
        {
            case '+':
                result = value1 + value2;
                break;
            case '-':
                result = value1 - value2;
                break;
            case '*':
                result = value1 * value2;
                break;
            case '/':
                result = value1 / value2;
                break;
            default:
                result = 0d;
                break;

        }

        return result;
    }
    public static double TernaryOperator(char operation, double value1, double value2)
    {
        return operation == '+' ? value1 + value2
                : operation == '-' ? value1 - value2
                : operation == '*' ? value1 * value2
                : operation == '/' ? value1 / value2
                : 0;
    }
    public static double SwitchExpression(char operation, double value1, double value2)
    {
        return operation switch
        {
            '+' => value1 + value2,
            '-' => value1 - value2,
            '*' => value1 * value2,
            '/' => value1 / value2,
            _ => throw new ArgumentException("Unknown operation", $"{operation}")
        };
    }
}