namespace Question2
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EMail { get; private set; }
        private DateTime dob;

        public Person(string fname, string lname, string email, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            EMail = email;
            DOB = dob;
        }

        public Person(string fname, string lname, string email)
        {
            FirstName = fname;
            LastName = lname;
            EMail = email;
            // DOB = Dat;
        }

        public Person(string fname, string lname, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            DOB = dob;
        }
        public DateTime DOB
        {
            get { return dob; }
            set {
                    DateTime currentDate = DateTime.Now;
                    if ((value - currentDate).TotalDays / 365.255 < 0 || (DOB - currentDate).TotalDays / 365.255 > 120)
                    {
                        throw new System.ArgumentOutOfRangeException("Date of birth seems impossible");
                    }else{
                        dob = value;
                    }
                }
        }
        

        

        public bool IsAdult()
        {
            DateTime currentDate = DateTime.Now;
            double age = (DOB - currentDate).TotalDays / 365.255 ;
            return age > 18;
        }

        public bool IsBirthday()
        {
            DateTime currentDate = DateTime.Now;
            return (DOB.Day == currentDate.Day && DOB.Month == currentDate.Month);            
        }

        public string ScreenName()
        {
            return $"{FirstName[0]}{LastName}{DOB.Day}{DOB.Month}";
        }
    }
}