namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Height = 100;
            text.FontName = "Arial";
            text.FontSize = 16;

            text.Copy();

            Console.WriteLine("Hello");
        }
    }
}