using ClassLibrary;

namespace TestActions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int res = c.Add(2, 3);
        }
    }
}
