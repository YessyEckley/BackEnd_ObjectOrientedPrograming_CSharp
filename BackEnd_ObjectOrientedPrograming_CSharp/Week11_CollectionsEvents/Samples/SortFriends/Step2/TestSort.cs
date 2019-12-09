// TestSort.cs

using System;
using System.Collections;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.SortFriends.Step2
{

    public class TestSort
    {
        static void DisplayTest()
        {
            InputWrapper iw = new InputWrapper();
            string name = " ";
            string spouse;
            ArrayList MyMarriedFriends = new ArrayList();
            while (true)
            {
                Console.WriteLine("Enter friend's name, quit to exit");
                name = iw.getString("> ");
                if (name.Equals("quit"))
                    break;
                Console.WriteLine("Enter friend's spouse's name");
                spouse = iw.getString("> ");
                Friend node = new Friend(name, spouse);
                MyMarriedFriends.Add(node);
            }
            foreach (object o in MyMarriedFriends)
            {
                Friend f = (Friend)o;
                Console.WriteLine(f.ToString());
            }
            MyMarriedFriends.Sort(); // default sort
            Console.WriteLine("\nSorted by friend");
            foreach (object o in MyMarriedFriends)
            {
                Friend f = (Friend)o;
                Console.WriteLine(f.ToString());
            }
            MyMarriedFriends.Sort(new SpouseComparer()); // alternate sort
            Console.WriteLine("\nSorted by Spouse");
            foreach (object o in MyMarriedFriends)
            {
                Friend f = (Friend)o;
                Console.WriteLine(f.ToString());
            }
            Console.Write("Enter <cr> to end program");
            Console.ReadLine();
        }
    }


}