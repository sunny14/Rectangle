﻿
namespace Program
{
    public class Rectangle
    {
        private int length = 3;
        private int width = 2;
        private String color = "red";

        public Rectangle() { }

        public Rectangle( int inputLength, int inputWidth)
        {
            length = inputLength;
            width = inputWidth;
        }

        public Rectangle(int inputLength, int inputWidth, String inputColor)
        {
            length = inputLength;
            width = inputWidth;
            color = inputColor;
        }

        public void printColor()
        {
            Console.WriteLine("My color is top secret");
           // Console.WriteLine("Color is "+color);
        }

        public void printRectangle()
        {
            Console.WriteLine("length is "+length+", width is "+width+", color is "+color);
        }


        //השיטה מדפיסה שטח של מלבן
        public void printSquare()
        {
            int square = length * width;
            Console.WriteLine("The square is " + square);
        }

        public void printPerimeter()
        {
            int perimeter = width * 2 + length * 2;
            Console.WriteLine("The perimeter is " + perimeter);
        }

        public void doubleRectagle ()
         {
            length = length * 2;
            width = width * 2;

            Console.WriteLine("new length is " + length+", new width is "+width);

        }


    }
}