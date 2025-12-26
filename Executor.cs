namespace CleanCode;
public static class Executor
{
	public static double ExecuteCleanCode(Shape[] shapes) 
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += shape.GetArea();
		}
		return sum;
	}
	public static double ExecuteCleanCodeWithoutPoly(UnionShape[] shapes)
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += GetAreaSwitch(shape);
		}
		return sum;
	}
	private static double GetAreaSwitch(UnionShape shape) => shape.type switch
	{
		ShapeType.Rectangle => shape.width*shape.length,
		ShapeType.Triangle => shape.width*shape.length * 0.5d,
		ShapeType.Circle => shape.width*shape.width * 3.14d,
		ShapeType.Square => shape.width*shape.width
	};
	public static double ExecuteCleanCodeWithoutPollyAndKnowingWhatsInside(UnionShape[] shapes)
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += GetAreaTable(shape);
		}
		return sum;
	}
	private static readonly double[] ctable = [1.0d, 0.5d, 1.0d, 3.14d];
	private static double GetAreaTable(UnionShape shape) =>
		shape.width*shape.length*ctable[(int)shape.type];
}
