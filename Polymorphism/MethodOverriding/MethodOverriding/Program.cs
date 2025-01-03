﻿namespace MethodOverriding
{
    class Program
	{
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle() { Height = 100, Width = 200});
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}