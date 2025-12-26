namespace CleanCode;
public enum ShapeType
{
	Rectangle=0,
	Triangle=1,
	Square=2,
	Circle=3
}
public struct UnionShape
{
	public ShapeType type;
	public double width;
	public double length;
	public UnionShape(ShapeType type, double width, double length)
	{
		this.type = type;
		this.width = width;
		this.length = length;
	}
}
