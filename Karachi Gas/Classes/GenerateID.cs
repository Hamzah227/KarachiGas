using System;

namespace Karachi_Gas.Classes
{
    class GenerateID
    {
        static int i = 000000;
        public static int ID_Sales()
        {
            i += 000001;
            Console.WriteLine(i);
            return i;

        }
    }
}
