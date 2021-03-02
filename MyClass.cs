using System;
using System.Collections.Generic;
using System.Text;

namespace OOPH_1
{
    // Framework vs. platform
    // - Værktøj, build, run (framework - web/desktop/mobil frameworks)
    // - Det som frameworks køre på er en platform.
    //
    // References og value types (strong type language types is the programmering language)
    // Refenrences ligger på disken
    // value typer ligger i hukommelsen




    class MyClass
    {
        // Attributes
        bool allowrite;
        int myint = 4;
        object myobject = null;



        // Properties
        string myproperty1 { get; set; }
        

        // Constructors
        public MyClass()
        {

        }
        public MyClass(string myprop1)
        {
            if (myprop1 != null && !myprop1.Equals("")) 

            myproperty1 = myprop1;
            allowrite = false;
                


            var tt = method1();
        }

        // Methods
        string method1()
        {
            return "";
        }
        public void showmessage()
        {
            if (allowrite == true)
                Console.WriteLine("Hello World");
            else
            {
                Console.WriteLine("allowrite is false.");
            }
            Console.ReadKey();
        }
        public void showAnimalSounds(Animals animalType)
        {
            switch(animalType)
            {
                case Animals.Dog:
                    Console.WriteLine("wov");
                    break;
                case Animals.Cat:
                    Console.WriteLine("miav");
                    break;
                case Animals.Kanin:
                    Console.WriteLine("squeek");
                    break;
                
            }



        }
        
    }
}
