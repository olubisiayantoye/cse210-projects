using System;
using System.Collections.Generic;

namespace PolymorphismShapes
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
      W06 Prepare: Learning Activity*/
   
    // Abstract base class Shape
    public abstract class Shape
    {
        protected string color;

        public Shape(string color)
        {
            this.color = color;
        }

        // Method to get the color of the shape
        public string GetColor()
        {
            return color;
        }

        // Abstract method to get the area of the shape
        public abstract float GetArea();
    }

    // Square class inheriting from Shape
    public class Square : Shape
    {
        private float side;

        public Square(string color, float side) : base(color)
        {
            this.side = side;
        }

        // Override method to calculate area for square
        public override float GetArea()
        {
            return side * side;
        }
    }

    // Rectangle class inheriting from Shape
    public class Rectangle : Shape
    {
        private float width;
        private float height;

        public Rectangle(string color, float width, float height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        // Override method to calculate area for rectangle
        public override float GetArea()
        {
            return width * height;
        }
    }

    // Circle class inheriting from Shape
    public class Circle : Shape
    {
        private float radius;

        public Circle(string color, float radius) : base(color)
        {
            this.radius = radius;
        }

        // Override method to calculate area for circle
        public override float GetArea()
        {
            return (float)Math.PI * radius * radius;
        }
    }

    // Main class to test the shapes
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list to hold shapes
            List<Shape> shapes = new List<Shape>();

            // Add different shapes to the list
            shapes.Add(new Square("Red", 4));
            shapes.Add(new Rectangle("Blue", 3, 6));
            shapes.Add(new Circle("Green", 5));

            // Iterate through the list of shapes and display their color and area
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
            }
        }
    }
}
