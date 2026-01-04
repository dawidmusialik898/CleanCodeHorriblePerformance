using System.Runtime.CompilerServices;
namespace CleanCode;
public static class Executor
{
	public static double GetAreaVirtualFunctions(Shape[] shapes) 
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += shape.GetArea();
		}
		return sum;
	}
	public static double GetAreaSwitch(UnionShape[] shapes)
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += AreaSwitch(shape);
		}
		return sum;
	}
	private static double AreaSwitch(UnionShape shape) => shape.type switch
	{
		ShapeType.Rectangle => shape.width*shape.length,
		ShapeType.Triangle => shape.width*shape.length * 0.5d,
		ShapeType.Circle => shape.width*shape.width * 3.14d,
		ShapeType.Square => shape.width*shape.width
	};
	public static double GetAreaSwitchInlined(UnionShape[] shapes)
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += AreaSwitchInlined(shape);
		}
		return sum;
	}
	[MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
	private static double AreaSwitchInlined(UnionShape shape) => shape.type switch
	{
		ShapeType.Rectangle => shape.width*shape.length,
		ShapeType.Triangle => shape.width*shape.length * 0.5d,
		ShapeType.Circle => shape.width*shape.width * 3.14d,
		ShapeType.Square => shape.width*shape.width
	};
	public static double GetAreaIf(UnionShape[] shapes)
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += AreaIf(shape);
		}
		return sum;
	}
	private static double AreaIf(UnionShape shape)
	{
		if(shape.type == ShapeType.Rectangle)
			return shape.width * shape.length;
		else if(shape.type == ShapeType.Triangle)
			return shape.width * shape.length * 0.5d;
		else if(shape.type == ShapeType.Circle)
			return shape.width * shape.width * 3.14d;
		else if(shape.type == ShapeType.Square)
			return shape.width * shape.width;

		return 0d;
	}
	public static double GetAreaTable(UnionShape[] shapes)
	{
		double sum = 0d;
		foreach(var shape in shapes)
		{
			sum += AreaTable(shape);
		}
		return sum;
	}
	private static readonly double[] ctable = [1.0d, 0.5d, 1.0d, 3.14d];
	private static double AreaTable(UnionShape shape) =>
		shape.width*shape.length*ctable[(int)shape.type];
}
