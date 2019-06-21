using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Console
{
    class Program
    {
        //private static Dictionary<string, object> dict;
        //private static void Add(string strKey, object dataType)
        //{
        //    if (!dict.ContainsKey(strKey))
        //    {
        //        dict.Add(strKey, dataType);
        //    }
        //    else
        //    {
        //        dict[strKey] = dataType;
        //    }
        //}
        //private static T GetAnyValue<T>(string strKey)
        //{
        //    object obj;
        //    T retType;

        //    dict.TryGetValue(strKey, out obj);

        //    try
        //    {
        //        retType = (T)obj;
        //    }
        //    catch
        //    {
        //        retType = default(T);
        //    }
        //    return retType;
        //}
        static void Main(string[] args)
        {
            //dict = new Dictionary<string, object>();
            //Add("pi", 3.14159);
            //Add("Josh", "Proffitt");
            //Add("Soup", "This is soup.");
            //Add("I", 45);

            //Console.WriteLine("pi = " + GetAnyValue<double>("pi"));
            //Console.WriteLine("Josh " + GetAnyValue<string>("Josh"));
            //Console.WriteLine("Soup = " + GetAnyValue<string>("Soup"));
            //Console.WriteLine("I = " + GetAnyValue<int>("I"));
            //Console.WriteLine("J = " + GetAnyValue<int>("J"));
            //Console.ReadLine();
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
