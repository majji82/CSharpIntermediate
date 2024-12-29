namespace Classes
{
    public class PersonProperty
    {
        public DateTime Birthdate { get; private set; }

        public PersonProperty(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                return timeSpan.Days / 365;
            }
        }
    }
}