namespace AbstractClasses
{
    class Program
	{
        static void Main(string[] args)
        {
            //var shape = new Shape(); 

            Circle c = new Circle();
            c.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}