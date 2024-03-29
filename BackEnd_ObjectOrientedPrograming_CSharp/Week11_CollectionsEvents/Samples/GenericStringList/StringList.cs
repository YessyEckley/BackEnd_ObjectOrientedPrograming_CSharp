// StringList.cs

using System;
using System.Collections.Generic;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.GenericStringList
{
    public class StringList
    {
        private static List<string> list;
        public static void DisplayTest()
        {
            // Initialize strings and show starting state
            list = new List<string>(4);
            ShowCount();
            AddString("Bob");
            AddString("Mary");
            AddString("Charlie");
            ShowList(list);
            ShowCount();
            // Command processing loop
            InputWrapper iw = new InputWrapper();
            string cmd;
            Console.WriteLine("Enter command, quit to exit");
            cmd = iw.getString("> ");
            while (!cmd.Equals("quit"))
            {
                try
                {
                    if (cmd.Equals("show"))
                        ShowList(list);
                    else if (cmd.Equals("array"))
                        ShowArray(list);
                    else if (cmd.Equals("enum"))
                        ShowEnum(list);
                    else if (cmd.Equals("add"))
                    {
                        string str = iw.getString("string: ");
                        AddString(str);
                    }
                    else if (cmd.Equals("remove"))
                    {
                        string str = iw.getString("string: ");
                        RemoveString(str);
                    }
                    else if (cmd.Equals("removeat"))
                    {
                        int index = iw.getInt("index: ");
                        RemoveAt(index);
                    }
                    else if (cmd.Equals("index"))
                    {
                        string str = iw.getString("string: ");
                        ShowIndex(str);
                    }
                    else if (cmd.Equals("count"))
                        ShowCount();
                    else if (cmd.Equals("sort"))
                        Sort();
                    else
                        help();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    if (e.InnerException != null)
                    {
                        Console.WriteLine(e.InnerException.Message);
                    }
                }
                cmd = iw.getString("> ");
            }
        }
        private static void ShowList(List<string> array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }
        private static void ShowArray(List<string> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
        }
        private static void ShowEnum(List<string> array)
        {
            IEnumerator<string> iter = array.GetEnumerator();
            bool more = iter.MoveNext();
            while (more)
            {
                string str = (string)iter.Current;
                Console.WriteLine(str);
                more = iter.MoveNext();
            }
        }
        private static void ShowCount()
        {
            Console.WriteLine("list.Count = {0}", list.Count);
            Console.WriteLine("list.Capacity = {0}", list.Capacity);
        }
        private static void ShowIndex(string str)
        {
            int i = list.IndexOf(str);
            if (i == -1)
                throw new Exception(str + " not on list");
            else
                Console.WriteLine("index = {0}", i);
        }
        private static void AddString(string str)
        {
            if (list.Contains(str))
                throw new Exception("list contains " + str);
            list.Add(str);
        }
        private static void RemoveString(string str)
        {
            if (list.Contains(str))
                list.Remove(str);
            else
                throw new Exception(str + " not on list");
        }
        private static void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }
        private static void Sort()
        {
            list.Sort();
        }
        private static void help()
        {
            Console.WriteLine("The following commands are available:");
            Console.WriteLine("\tadd      -- add a string");
            Console.WriteLine("\tarray    -- show strings via array loop");
            Console.WriteLine("\tcount    -- show count and capacity");
            Console.WriteLine("\tenum     -- show all strings via enumerator");
            Console.WriteLine("\tindex    -- find index of string");
            Console.WriteLine("\tremove   -- remove a string");
            Console.WriteLine("\tremoveat -- remove a string at index");
            Console.WriteLine("\tshow     -- show all strings");
            Console.WriteLine("\tsort     -- sort all strings");
            Console.WriteLine("\tquit     -- exit the program");
        }
    }
}