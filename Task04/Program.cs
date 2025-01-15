namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ensure that the Manager class also calls the Work method of the Employee class within its  Overridden method   
            //Manager manager = new Manager();
            //manager.Work();
            #endregion

            #region Then explain the difference between using override and new (using binding behavior)	
            //BaseClass baseClass = new DerivedClass2();
            //BaseClass baseClass02 = new DerivedClass1();

            //baseClass.DisplayMessage();   // static Binding - Iam a Base Class 
            //baseClass02.DisplayMessage(); // Dynamic Binding - Iam A DerivedClass1

            #endregion

            #region Constructor Overloading

            //Duration D = new Duration(10,20,30);
            //Console.WriteLine(D);

            //Duration D1 = new Duration(666);
            //Console.WriteLine(D1);

            //Duration D2 = new Duration(4000);
            //Console.WriteLine(D2);


            #endregion

            #region OverLoading
            Duration D1 = new Duration(2,30,30);
            Duration D2 = new Duration(1, 20, 30);
            Duration D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 - D2;
            Console.WriteLine(D3);

            D3 = D1 + 70;
            Console.WriteLine(D3);

            Console.WriteLine(++D1);
            

            if(D1)
            {
                Console.WriteLine(1);
            }

            DateTime obj = (DateTime)D1;
            Console.WriteLine(obj);



            #endregion

        }
    }
}
