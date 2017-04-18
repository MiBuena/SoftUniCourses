using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DrawingTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();


            if (figureType == "Square")
            {
                int number = int.Parse(Console.ReadLine());

                Square square = new Square();

                CorDraw drawer = new CorDraw(square);

                drawer.Figure.Draw(number);
            }
            else
            {
                int number = int.Parse(Console.ReadLine());

                int number2 = int.Parse(Console.ReadLine());

                Rectangle rectangle = new Rectangle();

                CorDraw drawer = new CorDraw(rectangle);

                drawer.Figure.Draw(number, number2);
            }
        }
    }

    interface IDrawable
    {
        void Draw(params int[] size);
    }

    class CorDraw
    {
        public CorDraw(IDrawable figure)
        {
            this.Figure = figure;
        }

        public IDrawable Figure { get; set; }
    }

    class Rectangle : IDrawable
    {
        public void Draw(params int[] size)
        {
            for (int row = 0; row < size[1]; row++)
            {
                Console.Write("|");

                if (row == 0 || row == size[1] - 1)
                {
                    for (int col = 0; col < size[0]; col++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int col = 0; col < size[0]; col++)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("|");
            }

        }
    }

    class Square : IDrawable
    {
        public void Draw(params int[] size)
        {
            for (int row = 0; row < size[0]; row++)
            {
                Console.Write("|");

                if (row == 0 || row == size[0] - 1)
                {
                    for (int col = 0; col < size[0]; col++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int col = 0; col < size[0]; col++)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("|");
            }

        }
    }
}
