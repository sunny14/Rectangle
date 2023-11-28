namespace Program
{
    // using System;

    class Program
    {
        static void Main(string[] args)
        {
           /* Rectangle myRectangle = new Rectangle();
            myRectangle.printRectangle();


            Rectangle customSizeRectangle = new Rectangle(8, 16);
            customSizeRectangle.printRectangle();*/

            Rectangle customSizeColorRectangle = new Rectangle(10, 100, "blue");
            customSizeColorRectangle.printRectangle();


            customSizeColorRectangle.printColor();
           // customSizeColorRectangle.color

            //  myRectangle.printSquare();
            //   myRectangle.printPerimeter();

            //   myRectangle.doubleRectagle();

        }
    }

}