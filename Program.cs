using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "枪的描述";
            string gunName;
            int gunCount;
            Console.WriteLine("请输入枪的名字");
            gunName = Console.ReadLine();
            string str = string.Format("枪\n的名字为:{0}", gunName);
            Console.WriteLine(str);

        }   
    }
}
