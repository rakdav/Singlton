IExpression terminalExpression = new TermanalExpression("hello");
IExpression nonTerminalExpression = new NonTerminalExpression(terminalExpression, 2);
nonTerminalExpression.Interpret();
interface IExpression
{
    public void Interpret();
}
class TermanalExpression : IExpression
{
    private string statement;

    public TermanalExpression(string _statement)
    {
        this.statement = _statement;
    }
    public void Interpret()
    {
        Console.WriteLine(statement+" TerminalExpression");
    }
}
class NonTerminalExpression : IExpression
{
    private IExpression expression;
    private int times;

    public NonTerminalExpression(IExpression _expression, int _times)
    {
        this.expression = _expression;
        this.times = _times;
    }
    public void Interpret()
    {
        for (int i = 0; i < times; i++) expression.Interpret();
    }
}
