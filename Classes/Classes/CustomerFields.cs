namespace Classes
{
    public class CustomerFields
    {
        public int Id;
        public string Name;
        public readonly List<OrderFields> Orders = new List<OrderFields>();

        public CustomerFields(int id)
        {
            this.Id = id;
        }

        public CustomerFields(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<OrderFields> (); This gives error as it is readonly 
        }
    }
}