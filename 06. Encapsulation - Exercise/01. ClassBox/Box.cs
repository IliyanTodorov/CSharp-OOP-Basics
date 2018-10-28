public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double LateralSurfaceArea()
    {
        return 2 * length * height + 2 * width * height;
    }

    public double SurfaceArea()
    {
        return 2 * length * width + 2 * length * height + 2 * width * height;
    }

    public double Volume()
    {
        return length * width * height;
    }
}

