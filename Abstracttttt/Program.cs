namespace calc_level2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition n = new Addition();
            Subtraction n2 = new Subtraction();
            Multiplication n3 = new Multiplication();
            Division n4 = new Division();
            n.Operate(4, 6);
            n2.Operate(6, 68);
            n3.Operate(7, 5);
            n4.Operate(95, 5);
        }
    }
}