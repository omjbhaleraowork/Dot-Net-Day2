namespace StaticMember
{
    internal class Program
    {
        static void Main()
        {
            MyClass o1 = new MyClass { i=20};
            MyClass o2 = new MyClass { i=100};
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);

            MyClass.s_i = 201;
            Console.WriteLine(MyClass.s_i);

            o1.Display();
            MyClass.s_Display();


        }
    }
    public class MyClass
    {
        public int i;
        public static int s_i;

        public  void Display()
        {
            Console.WriteLine("Display");
            Console.WriteLine(i);
            Console.WriteLine(s_i);
        }


        public static void s_Display()
        {
            Console.WriteLine("static Display");
          //  Console.WriteLine(i);
            Console.WriteLine(s_i);
        }
    }
}