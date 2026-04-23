namespace StateInfo
{
    public class StateInfo
    {
        public string stateName { get; set; }
        public int population { get; set; }
        public string flagDescription { get; set; }
        public string stateFlower { get; set; }
        public string stateBird { get; set; }
        public string firstLargestCity { get; set; }
        public string secondLargestCity { get; set; }
        public string thirdLargestCity { get; set; }
        public string capital { get; set; }
        public double medianIncome { get; set; }
        public decimal computerJobPercentage { get; set; }

    

    public StateInfo()
        {
            stateName = "";
            population = 0;
            flagDescription = "";
            stateFlower = "";
            stateBird = "";
            firstLargestCity = "";
            secondLargestCity = "";
            thirdLargestCity = "";
            capital = "";
            medianIncome = 0;
            computerJobPercentage = 0m;
        }

    } 
}
