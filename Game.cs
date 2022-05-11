
namespace cse210{

    class Game{
        private bool keepPlaying;
        private GameInformation _gameInformation;
        private string userInput;

        public Game()
        {
            this.keepPlaying = true;
            _gameInformation = new GameInformation();
            userInput = "None";
        }
        public void PlayGame(){
            /// <summary>
            /// Prints out the console, and call appropriate functions.
            /// </summary>
            /// <returns> in loop until finnished</returns>
            while (keepPlaying){
                Console.WriteLine($"the card is : {_gameInformation.GetCurrentCard()}");
                HigherLower(Playing);
                Console.WriteLine($"next card was : {_gameInformation.GetNextCard()}");
                Console.WriteLine($"Your current score is : {_gameInformation.GetScore()}");               
                keepPlaying = UserInputContinue();
                _gameInformation.SetNextCard();
                Console.WriteLine();
            }

        }
        
        public void HigherLower(bool keepPlaying){
            /// <summary>
            /// Check's score, and compares against the user input
            /// </summary>
            /// <setscore>int</setscore>
            Console.WriteLine("Higher or Lower?(h/l)(To stop playing type: 'n'):");
            userInput = Console.ReadLine();
            if (userInput == "h" && _gameInformation.CheckScore() || (userInput == "l" && _gameInformation.CheckScore() == false)){
                _gameInformation.SetScore(-75);
            }
            if (userInput == "n" ){
                Console.WriteLine($"your score is {_gameInformation.GetScore()}, thanks for playing.");
                keepPlaying = false;
            }
            else{
                _gameInformation.SetScore(100);
            }
        }
        public bool UserInputContinue(){
            /// <summary>
            /// Gets the user input
            /// </summary>
            /// <returns>bool</returns>
            Console.WriteLine("Do you want to continue (y/n)?");
            if (Console.ReadLine() == "y"){            
                return true;    
            }
            else{
                Console.WriteLine($"your score is {_gameInformation.GetScore()}, thanks for playing.");
                return false;
            }
        }


    }


}