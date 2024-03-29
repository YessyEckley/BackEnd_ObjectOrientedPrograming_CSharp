// ChatServer.cs

using System;
using System.Collections.Generic;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.EventDemo.Step2
{
    public class ChatEventArg : EventArgs
    {
        public string Name;
        public ChatEventArg(string name)
        {
            Name = name;
        }
    }

    public delegate void JoinHandler(object sender, ChatEventArg e);
    public delegate void QuitHandler(object sender, ChatEventArg e);

    public class ChatServer
    {
        private List<string> members = new List<string>();
        private string chatName;
        public event JoinHandler Join;
        public event QuitHandler Quit;
        public ChatServer(string chatName)
        {
            this.chatName = chatName;
        }
        override public string ToString()
        {
            return chatName;
        }
        protected void OnJoin(ChatEventArg e)
        {
            if (Join != null)
            {
                Join(this, e);
            }
        }
        protected void OnQuit(ChatEventArg e)
        {
            if (Quit != null)
            {
                Quit(this, e);
            }
        }
        public void JoinChat(string name)
        {
            members.Add(name);
            OnJoin(new ChatEventArg(name));
        }
        public void QuitChat(string name)
        {
            members.Remove(name);
            OnQuit(new ChatEventArg(name));
        }
        public void ShowMembers(string msg)
        {
            Console.WriteLine("--- " + msg + "---");
            foreach (string member in members)
            {
                Console.WriteLine(member);
            }
        }
    }
}