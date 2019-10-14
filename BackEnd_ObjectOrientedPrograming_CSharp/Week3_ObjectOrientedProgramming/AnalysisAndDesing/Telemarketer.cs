namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.AnalysisAndDesing
{
    public class Telemarketer : Person, IPest
    {
        public void BeAnnoying()
        {
            //throw new NotImplementedException();
            //Write some code to be annoying
            CallDuringDinner();
            ContinueTalkingWhenYouSayNo();
        }

        public void CallDuringDinner() { }
        public void ContinueTalkingWhenYouSayNo() { }
    }
}
