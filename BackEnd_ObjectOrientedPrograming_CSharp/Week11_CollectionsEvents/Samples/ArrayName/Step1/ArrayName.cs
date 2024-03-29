// ArrayName.cs - Step 1

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.ArrayName.Step1
{
    public class Name
    {
        private string text;
        public Name(string text)
        {
            this.text = text;
        }
        public string Text
        {
            get
            {
                return text;
            }
        }
    }
    public class ArrayName
    {
        public static int DisplayTest()
        {
            Name[] array = new Name[10];
            array[0] = new Name("Michael");
            array[1] = new Name("Charlie");
            array[2] = new Name("Peter");
            array[3] = new Name("Dana");
            array[4] = new Name("Bob");
            if (array[0] is IComparable)
                Array.Sort(array);
            else
                Console.WriteLine("Name does not implement IComparable");
            return 0;
        }
    }
}