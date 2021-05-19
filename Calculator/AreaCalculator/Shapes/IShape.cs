namespace AreaCalculator.Shapes
{
    public interface IShape
    {
        int SideCount { get; }
        double GetSquare();
    }
}