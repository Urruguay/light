using static System.Console;
namespace Task_2
{
    public class DoubleTypes<T1, T2>
    {
        public T1 var1;
        public T2 var2;

        public DoubleTypes() { }
        public DoubleTypes(T1 var1, T2 var2)
        {
            this.var1 = var1;
            this.var2 = var2;
        }

        public void Print()
        {
            WriteLine($"var1: {var1}\nvar2: {var2}");
        }
    }
}
