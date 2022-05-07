using System;

namespace Changethis{
    class ChangeNameP{
        private string givenname;
        private string familyname;
        private string easter_name;
        private string western_name;
        
        public ChangeNameP(string fname, string lname){
            givenname = fname;
            familyname = lname;
        }
        public void make_easter_name(){
           easter_name = givenname; 
        }
        public void show_easter_name(){
            Console.WriteLine($"{givenname} {familyname}");
        }
        public
        }
    }
}