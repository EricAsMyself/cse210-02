

using cse210;

namespace Changethis{
    class Game{
        private bool keepPlaying;
        private GameInformation _gameInformation;

        public Game()
        {
            this.keepPlaying = true;
            _gameInformation = new GameInformation();
        }
        public void PlayGame(){
            while (keepPlaying){
                Console.WriteLine($"the card is :{_gameInformation.GetCurrentCard()}");
                HigherLower();
                Console.WriteLine($"next card is :{_gameInformation.GetCurrentCard()}");
                Console.WriteLine($"next card is :{_gameInformation.GetCurrentCard()}");
            }

        }
        
        public String HigherLower(){
            Console.WriteLine("HIgher or Lower? :");
            return Console.ReadLine();
        }

    }


}


// int GetCurrentCard() -> returns currently selected card
// int GetNextCard() -> returns next card in queue
// void SetNextCard() -> 
// int GetScore() -> returns current score value
// void SetScore(int value) -> adds/subtracts value from current score value
// bool CheckScore() -> returns true if next card is higher than current card
