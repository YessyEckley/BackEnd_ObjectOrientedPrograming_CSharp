namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.AnalysisAndDesing
{
    public class HouseFly : Insect, IPest
    {
        public void BeAnnoying()
        {
            //throw new NotImplementedException();
            //Write some code to be annoying
            FlyAroundYourHead();
            LandOnThings();
        }

        public void FlyAroundYourHead() { }
        public void LandOnThings() { }
    }
}
