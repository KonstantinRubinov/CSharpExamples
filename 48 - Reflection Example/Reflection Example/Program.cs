using Entities;
using System;
using System.Reflection;

namespace Reflection_Example
{
    class Program
    {
        static void FindTypeOfClass(object obj)
        {
            Type t1 = obj.GetType();
            Type t2 = typeof(Person);
        }

        static void Main(string[] args)
        {
            TestType();
            CreateDynamicInstance();
            DisplayConsoleColors();

            // AppDomain.CurrentDomain.GetAssemblies()
            AppDomain ad = AppDomain.CreateDomain("MySecondDomain");
        }

        static void DisplayConsoleColors()
        {
            string[] colorNames = Enum.GetNames(typeof(ConsoleColor));
            foreach (string color in colorNames)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                Console.WriteLine(color);
                Console.ResetColor();
            }
        }
        
        static void CreateDynamicInstance()
        {
            Assembly asm = Assembly.LoadFile(@"C:\Projects\2019-01-10 - Exams\Reflection Example\Entities\bin\Debug\Entities.dll");
            Type t = asm.GetType("Entities.Person");
            object myPerson = Activator.CreateInstance(t);

            PropertyInfo fullNameProperty = t.GetProperty("FullName");
            fullNameProperty.SetValue(myPerson, "Moishe Ufnik");

            PropertyInfo ageProperty = t.GetProperty("Age");
            ageProperty.SetValue(myPerson, 12);

            MethodInfo displayMethod = t.GetMethod("Display");
            displayMethod.Invoke(myPerson, null);

            FieldInfo ageField = t.GetField("_age", BindingFlags.NonPublic | BindingFlags.Instance);
            ageField.SetValue(myPerson, -12);

            displayMethod.Invoke(myPerson, null);
        }

        private static void TestType()
        {
            Type t = typeof(Person); // Reflection
            
            Console.WriteLine("IsClass: " + t.IsClass);
            Console.WriteLine("IsArray: " + t.IsArray);
            Console.WriteLine("IsSealed: " + t.IsSealed);
            Console.WriteLine("IsValueType: " + t.IsValueType);
            Console.WriteLine("IsSerializable: " + t.IsSerializable);

            MethodInfo[] methods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Methods: ");
            foreach (MethodInfo item in methods)
                Console.WriteLine("\t" + item.Name);
            Console.WriteLine();
        }
    }
}
