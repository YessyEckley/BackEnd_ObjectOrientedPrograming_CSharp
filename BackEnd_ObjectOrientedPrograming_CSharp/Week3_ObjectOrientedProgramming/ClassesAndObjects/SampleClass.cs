using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.ClassesAndObjects
{
    public class SampleClass //: SampleStruct - This is a sealed non-intatiated special class
    {
        //This is an attribute
        public string SampleField;
        //This is a property
        public string SampleProperty { get; set; }

        private string _myWelcomeName;
        public string MyWelcomeName
        {
            get { return _myWelcomeName; }
            set { _myWelcomeName = $"Hello {value}!"; }
        }

        //This is a Constructor
        public SampleClass()
        {
            var aSampleStruct = new SampleStruct();
            // This is constructor - it can be left as is or perform additional logic
        }

        //Methods
        public string sampleMethod(string sampleParam)
        {
            // Insert code here
            return sampleParam;
        }

        public string sampleMethod(int sampleParam)
        {
            // Insert code here
            return sampleParam.ToString();
        }

        ~SampleClass()
        {
            // This is a destructor
            // Do some cleanup here and free your unmanaged resources
            Console.WriteLine("Finalized!");
        }

        // All classes in C# inherit from the object class
        // In here we are overriding one of its virtual methods
        public override string ToString() =>
            $"{MyWelcomeName} Welcome to our home!";
    }
}
