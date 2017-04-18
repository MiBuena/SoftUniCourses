using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<Rectangle> rectangleCollection = new List<Rectangle>();

            int n = inputNumbers[0];

            int m = inputNumbers[1];

            for (int i = 0; i < n; i++)
            {
                List<string> inputRectangles = Console.ReadLine().Split(' ').ToList();

                Rectangle newRectangle = new Rectangle(inputRectangles[0], decimal.Parse(inputRectangles[1]), decimal.Parse(inputRectangles[2]), decimal.Parse(inputRectangles[3]), decimal.Parse(inputRectangles[4]));

                rectangleCollection.Add(newRectangle);
            }

            for (int i = 0; i < m; i++)
            {
                List<string> inputIds = Console.ReadLine().Split(' ').ToList();

                Rectangle firstRectangle = rectangleCollection.FirstOrDefault(x => x.ID == inputIds[0]);

                Rectangle secondRectangle = rectangleCollection.FirstOrDefault(y => y.ID == inputIds[1]);

                bool intersect = firstRectangle.CheckIfIntersect(secondRectangle);

                Console.WriteLine(intersect.ToString().ToLower());
            }
        }
    }

    class Rectangle
    {
        public Rectangle(string id, decimal width, decimal height, decimal topLeftX, decimal topLeftY)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftY = topLeftY;
            this.TopLeftX = topLeftX;
        }

        public string ID { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal TopLeftX { get; set; }
        public decimal TopLeftY { get; set; }

        public bool CheckIfIntersect(Rectangle anotherRectangle)
        {
            decimal anotherRectRight = anotherRectangle.TopLeftX + anotherRectangle.Width;

            decimal thisRectRight = this.TopLeftX + this.Width;

            decimal anotherBottom = anotherRectangle.TopLeftY - anotherRectangle.Height;

            decimal thisBottom = this.TopLeftY - this.Height;

            if (this.TopLeftX > anotherRectRight || thisRectRight < anotherRectangle.TopLeftX ||
                this.TopLeftY < anotherBottom || thisBottom > anotherRectangle.TopLeftY)
            {
                return false;
            }

            return true;
        }
    }
}
