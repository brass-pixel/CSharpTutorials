namespace GetterSetter
{
    public class Movie
    {
        public string title; //public means anything can access these values
        public string director;
        private string rating; //private means only code inside class can access this variable

        public Movie(string aTitle, string aDirector, string aRating) 
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get {return rating;} //return attribute
            set {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                } 
                else
                {
                    value = "NR";
                }
            } //define a rule
        }
    }
}

