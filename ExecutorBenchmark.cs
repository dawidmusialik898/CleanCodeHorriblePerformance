using BenchmarkDotNet.Attributes;
namespace CleanCode;

[DisassemblyDiagnoser(maxDepth:2, exportCombinedDisassemblyReport:true)]
public class ExecutorBenchmark
{
	private readonly Shape[] shapes = [
		new Rectangle(1.22,1.47), new Rectangle(1.14,2.14),
		new Rectangle (1.14,3.14), new Rectangle(1.14,4.14),
		new Triangle(1.14,1.14), new Triangle(1.14,2.14),
		new Triangle(1.14,3.14), new Triangle(1.14,4.14),
		new Square(1.23),new Square(2.55),new Square(4.345),new Square(6.634),
		new Circle(1.123),new Circle(2.64),new Circle(4.77),new Circle(6.99),
		new Rectangle(1.22,1.47), new Rectangle(1.14,2.14),
		new Rectangle (1.14,3.14), new Rectangle(1.14,4.14),
		new Triangle(1.14,1.14), new Triangle(1.14,2.14),
		new Triangle(1.14,3.14), new Triangle(1.14,4.14),
		new Square(1.23),new Square(2.55),new Square(4.345),new Square(6.634),
		new Circle(1.123),new Circle(2.64),new Circle(4.77),new Circle(6.99),
		new Rectangle(1.22,1.47), new Rectangle(1.14,2.14),
		new Rectangle (1.14,3.14), new Rectangle(1.14,4.14),
		new Triangle(1.14,1.14), new Triangle(1.14,2.14),
		new Triangle(1.14,3.14), new Triangle(1.14,4.14),
		new Square(1.23),new Square(2.55),new Square(4.345),new Square(6.634),
		new Circle(1.123),new Circle(2.64),new Circle(4.77),new Circle(6.99),
		new Rectangle(1.22,1.47), new Rectangle(1.14,2.14),
		new Rectangle (1.14,3.14), new Rectangle(1.14,4.14),
		new Triangle(1.14,1.14), new Triangle(1.14,2.14),
		new Triangle(1.14,3.14), new Triangle(1.14,4.14),
		new Square(1.23),new Square(2.55),new Square(4.345),new Square(6.634),
		new Circle(1.123),new Circle(2.64),new Circle(4.77),new Circle(6.99),
	];

	[Benchmark]
	public double GetAreaVirtualFunctions() =>
		Executor.GetAreaVirtualFunctions(shapes);

	private readonly UnionShape[] unionShapes = [
		new UnionShape(ShapeType.Rectangle,1.22,1.47),
		new UnionShape(ShapeType.Rectangle,1.14,2.14),
		new UnionShape(ShapeType.Rectangle,1.14,3.14),
		new UnionShape(ShapeType.Rectangle,1.14,4.14),
		new UnionShape(ShapeType.Triangle,1.14,1.14),
		new UnionShape(ShapeType.Triangle,1.14,2.14),
		new UnionShape(ShapeType.Triangle,1.14,3.14),
		new UnionShape(ShapeType.Triangle,1.14,4.14),
		new UnionShape(ShapeType.Square,1.23,1.23),
		new UnionShape(ShapeType.Square,2.55,2.55),
		new UnionShape(ShapeType.Square,4.345,4.345),
		new UnionShape(ShapeType.Square,6.634,6.634),
		new UnionShape(ShapeType.Circle,1.123,1.123),
		new UnionShape(ShapeType.Circle,2.64,2.64),
		new UnionShape(ShapeType.Circle,4.77,4.77),
		new UnionShape(ShapeType.Circle,6.99,6.99),
		new UnionShape(ShapeType.Rectangle,1.22,1.47),
		new UnionShape(ShapeType.Rectangle,1.14,2.14),
		new UnionShape(ShapeType.Rectangle,1.14,3.14),
		new UnionShape(ShapeType.Rectangle,1.14,4.14),
		new UnionShape(ShapeType.Triangle,1.14,1.14),
		new UnionShape(ShapeType.Triangle,1.14,2.14),
		new UnionShape(ShapeType.Triangle,1.14,3.14),
		new UnionShape(ShapeType.Triangle,1.14,4.14),
		new UnionShape(ShapeType.Square,1.23,1.23),
		new UnionShape(ShapeType.Square,2.55,2.55),
		new UnionShape(ShapeType.Square,4.345,4.345),
		new UnionShape(ShapeType.Square,6.634,6.634),
		new UnionShape(ShapeType.Circle,1.123,1.123),
		new UnionShape(ShapeType.Circle,2.64,2.64),
		new UnionShape(ShapeType.Circle,4.77,4.77),
		new UnionShape(ShapeType.Circle,6.99,6.99),
		new UnionShape(ShapeType.Rectangle,1.22,1.47),
		new UnionShape(ShapeType.Rectangle,1.14,2.14),
		new UnionShape(ShapeType.Rectangle,1.14,3.14),
		new UnionShape(ShapeType.Rectangle,1.14,4.14),
		new UnionShape(ShapeType.Triangle,1.14,1.14),
		new UnionShape(ShapeType.Triangle,1.14,2.14),
		new UnionShape(ShapeType.Triangle,1.14,3.14),
		new UnionShape(ShapeType.Triangle,1.14,4.14),
		new UnionShape(ShapeType.Square,1.23,1.23),
		new UnionShape(ShapeType.Square,2.55,2.55),
		new UnionShape(ShapeType.Square,4.345,4.345),
		new UnionShape(ShapeType.Square,6.634,6.634),
		new UnionShape(ShapeType.Circle,1.123,1.123),
		new UnionShape(ShapeType.Circle,2.64,2.64),
		new UnionShape(ShapeType.Circle,4.77,4.77),
		new UnionShape(ShapeType.Circle,6.99,6.99),
		new UnionShape(ShapeType.Rectangle,1.22,1.47),
		new UnionShape(ShapeType.Rectangle,1.14,2.14),
		new UnionShape(ShapeType.Rectangle,1.14,3.14),
		new UnionShape(ShapeType.Rectangle,1.14,4.14),
		new UnionShape(ShapeType.Triangle,1.14,1.14),
		new UnionShape(ShapeType.Triangle,1.14,2.14),
		new UnionShape(ShapeType.Triangle,1.14,3.14),
		new UnionShape(ShapeType.Triangle,1.14,4.14),
		new UnionShape(ShapeType.Square,1.23,1.23),
		new UnionShape(ShapeType.Square,2.55,2.55),
		new UnionShape(ShapeType.Square,4.345,4.345),
		new UnionShape(ShapeType.Square,6.634,6.634),
		new UnionShape(ShapeType.Circle,1.123,1.123),
		new UnionShape(ShapeType.Circle,2.64,2.64),
		new UnionShape(ShapeType.Circle,4.77,4.77),
		new UnionShape(ShapeType.Circle,6.99,6.99)
	];

	[Benchmark]
	public double GetAreaSwitch() =>
		Executor.GetAreaSwitch(unionShapes);
	
	[Benchmark]
	public double GetAreaSwitchInline() =>
		Executor.GetAreaSwitchInlined(unionShapes);
	
	[Benchmark]
	public double GetAreaIf() =>
		Executor.GetAreaIf(unionShapes);

	[Benchmark]
	public double GetAreaTable() =>
		Executor.GetAreaTable(unionShapes);
}
