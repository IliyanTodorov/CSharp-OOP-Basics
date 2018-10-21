using System.Linq;

class Player
{
    private int Row { get; set; }
    private int Col { get; set; }
    public long Points { get; set; }

    public Player()
    {
        Points = 0;
    }

    public void SetCoordinates(string playerCoords)
    {
        var coords = playerCoords.Split().Select(int.Parse).ToArray();
        Row = coords[0];
        Col = coords[1];
    }

    public void CollectPoints(int[][] matrix)
    {
        while (Row >= 0 && Col < matrix[0].Length)
        {
            if (Row >= 0 && Row < matrix.Length && Col >= 0 && Col < matrix[0].Length)
            {
                Points += matrix[Row][Col];
            }
            Row--;
            Col++;
        }
    }
}