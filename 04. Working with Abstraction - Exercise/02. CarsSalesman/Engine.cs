using System.Text;
using System.Threading;

class Engine
{
    private string model;
    private int power;
    private int displacement;
    private string efficiency;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public int Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }

    public Engine()
    {
        this.displacement = -1;
        this.efficiency = "n/a";
    }

    public Engine(string model, int power)
        : this()
    {
        this.model = model;
        this.power = power;
    }

    public Engine(string model, int power, int displacement)
        : this(model, power)
    {
        this.displacement = displacement;
    }

    public Engine(string model, int power, string efficiency)
        : this(model, power)
    {
        this.efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power)
    {
        this.displacement = displacement;
        this.efficiency = efficiency;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"  {this.model}:");
        sb.AppendLine($"    Power: {this.power}");
        sb.Append($"    Displacement: ");
        sb.AppendLine(this.displacement == -1 ? "n/a" : this.displacement.ToString());
        sb.AppendLine($"    Efficiency: {this.efficiency}");

        return sb.ToString();
    }
}
