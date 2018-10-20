namespace _02._PointInRectangle
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int[] cornersPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rectangle = new Rectangle()
            {
                TopLeft = new Point(cornersPoints[0], cornersPoints[1]),
                BottomRight = new Point(cornersPoints[2], cornersPoints[3])
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] points = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Console.WriteLine(rectangle.Contains(new Point(points[0], points[1])));
            }
        }
    }
}
