
namespace cse210{

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
                Console.WriteLine($"next card was :{_gameInformation.GetNextCard()}");
                Console.WriteLine($"next card is :{_gameInformation.GetScore()}");               
                keepPlaying = UserInputContinue();
                _gameInformation.SetNextCard();
            }

        }
        
        public void HigherLower(){
            Console.WriteLine("Higher or Lower? :");
            if (Console.ReadLine() == "Higher" && _gameInformation.CheckScore()|| (Console.ReadLine() == "Lower" && _gameInformation.CheckScore() == false)){
                _gameInformation.SetScore(100);
            }
            else{
                _gameInformation.SetScore(-75);
            }
        }
        public bool UserInputContinue(){
            Console.WriteLine("Do you want to continue (y/n)?");
            if (Console.ReadLine() == "y"){            
                return true;    
            }
            else{
                return false;
            }
        }


    }


}