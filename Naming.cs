using System;

namespace Changethis{
    class Names{
        private string givenname;
        private string familyname;
        private string easter_name;
        private string western_name;
        
        public Names(string fname, string lname){
            this.givenname = fname;
            this.familyname = lname;
        }
        public string make_easter_name(){
           easter_name = givenname; 
           return easter_name;
        }
        public string make_western_name(){
           easter_name = givenname; 
           return easter_name;
        }
        public void show_easter_name(){
            Console.WriteLine(this.easter_name);
        }
        public void show_western_name(){
            Console.WriteLine(this.western_name);
        }
    }
}