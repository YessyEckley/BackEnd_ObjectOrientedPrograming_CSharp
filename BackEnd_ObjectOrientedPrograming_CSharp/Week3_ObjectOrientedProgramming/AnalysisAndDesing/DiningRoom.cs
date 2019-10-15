using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.AnalysisAndDesing
{
    public class DiningRoom
    {
        //Read-only can only be assign in the constructor
        private readonly Person[] _dinners;
        private readonly IPest[] _pests;

        private bool _areDinnersEating;
        public bool AreDinnersEating
        {
            get { return _areDinnersEating; }
            set { _areDinnersEating = value; }
        }

        public DiningRoom(Person[] diningPeople, IPest[] pests)
        {
            _dinners = diningPeople;
            _pests = pests;

            _areDinnersEating = _dinners.Length > 0;
        }

        public void ServeDinner()
        {
            if (AreDinnersEating)
            {
                foreach (var pest in _pests)
                {
                    pest.BeAnnoying();
                }
            }
        }
    }
}
