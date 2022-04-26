namespace ObjectMethods
{
    public class students
    {
        public string name;
        public string major;
        public double gpa;

        public students(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors() //Object Method
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}