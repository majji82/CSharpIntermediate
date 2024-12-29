namespace Classes
{
    public class PersonAccessModifier
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate)
        {
            if (!String.IsNullOrEmpty(birthDate.ToString()))
            {
                this._birthDate = birthDate;
            }
        }

        public string GetBirthDate()
        {
            return _birthDate.ToString();
        }
    }
}