// Contact.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.Week5Labs.TestContact.Step1
{
    public class Contact
    {
        private int id;
        private string name;
        private string email;
        public void ChangeId(int newId)
        {
            id = newId;
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public void ChangeEmail(string newEmail)
        {
            email = newEmail;
        }
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public string GetEmail()
        {
            return email;
        }
    }
}