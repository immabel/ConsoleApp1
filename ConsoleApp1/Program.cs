using MatrixClassLibrary;
using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[,]
            {
                { 4, 7, 6 },
                { 2, 15, 9 },
                { 3, 5, 1 }
            };

            Matrix matrix = new Matrix(mat);

            Console.WriteLine("Print: ");
            matrix.Print();

            Assembly assembly = Assembly.LoadFrom("MatrixClassLibrary.dll");
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }

            Type myType = Type.GetType("MatrixClassLibrary.Matrix, MatrixClassLibrary", false, true);
            foreach (var mi in myType?.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Console.Read();
        }
    }
}
