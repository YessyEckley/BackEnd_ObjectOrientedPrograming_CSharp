// ChatClient.cs - Step 2

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.EventDemo.Step2
{
    public class ChatClient
    {
        public static void OnJoinChat(object sender, ChatEventArg e)
        {
            Console.WriteLine("sender = {0}, {1} has joined the chat", sender, e.Name);
        }
        public static void OnQuitChat(object sender, ChatEventArg e)
        {
            Console.WriteLine("sender = {0}, {1} has quit the chat", sender, e.Name);
        }
        public static void DisplayTest()
        {
            ChatServer chat = new ChatServer("MSN Chat Room");
            // Register to receive event notifications from the server
            chat.Join += new JoinHandler(OnJoinChat);
            chat.Quit += new QuitHandler(OnQuitChat);
            // Call methods on the server
            chat.JoinChat("Michael");
            chat.JoinChat("Bob");
            chat.JoinChat("Sam");
            chat.ShowMembers("After 3 have joined");
            chat.QuitChat("Bob");
            chat.ShowMembers("After 1 has quit");
        }
    }
}