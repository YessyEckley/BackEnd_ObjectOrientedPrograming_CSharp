using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.AnalysisAndDesing
{
    public class DiningRoom
    {
        private readonly Person[] _dinners;
        private readonly IPest[] _pests;
        private readonly bool _areDinnersEating;

        public DiningRoom(Person[] diningPeople, IPest[] pests)
        {
            _dinners = diningPeople;
            _pests = pests;

            _areDinnersEating = _dinners.Length > 0;
        }

        public void ServeDinner()
        {
            if (_areDinnersEating)
            {
                foreach (var pest in _pests)
                {
                    pest.BeAnnoying();
                }
            }
        }
    }
}
