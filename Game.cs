

namespace Changethis{
    class Game{
        private bool keepPlaying;

        public void Game(){
            this.keepPlaying = true;
        }
        public void PlayGame(){
            while (keepPlaying){
                Console.WriteLine($"the card is :{CurrentCard()}");
                HigherLower();
                Console.WriteLine($"next card is :{CurrentCard()}");
                Console.WriteLine($"next card is :{CurrentScore()}");
            }

        }
        public int CurrentCard(){
            return GameInformation.GetCurrentCard();
        }
        public String HigherLower(){
            Console.WriteLine("HIgher or Lower? :");
            return Console.ReadLine();
        }
        public void NextCard(){
            return GameInformation.GetNextCard();
        }
        public void CurrentScore(){
            return GameInfromation.CheckScore();
        }

    }


}


// int GetCurrentCard() -> returns currently selected card
// int GetNextCard() -> returns next card in queue
// void SetNextCard() -> 
// int GetScore() -> returns current score value
// void SetScore(int value) -> adds/subtracts value from current score value
// bool CheckScore() -> returns true if next card is higher than current card
