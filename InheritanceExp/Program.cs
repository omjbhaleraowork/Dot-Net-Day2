namespace InheritanceExp
{
    internal class Program
    {
        static void Main()
        {
            BaseClass o1 = new BaseClass();
            //o1.
        }
    }

    public class BaseClass 
    {
        public int PUBLIC;
        private int PRIVATE;


        protected int PROTECTED;

        internal int INTERNAL;

        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;
    }
    public class DerivetdClass: BaseClass
    {
        void DoNothing()
        {
           // this.
        }
    }

    public class DerivetdClass2 : TestAccessModifiers.TestClass
    {
        void DoNothing2()
        {
            //this.
        }
    }


}