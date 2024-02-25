namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     // 1 byte
            sbyte c = 5;    // 1 byte

            short s = 5;    // 2 byte
            ushort us = 5;  // 2 byte

            Int16 i16 = 5;  // 2 byte
            int i = 5;      // 4 byte
            Int32 i32 = 5;  // 4 byte
            Int64 i64 = 5;  // 8 byte

            uint ui = 5;    // 4 byte
            long l = 5;     // 8 byte
            ulong ul = 5;   // 8 byte

            float f = 5.2f;    // 4 byte
            double d = 5.2;    // 8 byte
            decimal de = 5.2m; // 16 bye

            char ch = '5';           // 2 byte
            string str = "task";    //infinite

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "My Name";
            string name = "my";
            string surname = "name";
            string fullname = name + surname;

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            bool b3 = 10 < 2;
            bool b4 = 10 > 2;

            string str20 = "20";
            int int20 = 20;
            string newvalue = str20 + int20.ToString();
            Console.WriteLine(newvalue);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
