namespace CleanCode;

public abstract class Shape
{
	public abstract double GetArea();
}
public class Rectangle : Shape
{
	private double width;
	private double hight;
	public Rectangle(double width, double hight)
	{
		this.width = width;
		this.hight = hight;
	}
	override public double GetArea()
	{
		return width * hight;
	}
}
public class Square : Shape
{
	private double side;
	public Square(double side)
	{
		this.side = side;
	}
	override public double GetArea()
	{
		return side * side;
	}
}
public class Triangle : Shape
{
	private double tri_base;
	private double hight;
	public Triangle(double tri_base, double hight)
	{
		this.tri_base= tri_base;
		this.hight = hight;
	}
	override public double GetArea()
	{
		return  tri_base* hight / 2;
	}
}
public class Circle : Shape
{
	private double radious;
	public Circle(double radious)
	{
		this.radious = radious;
	}
	override public double GetArea()
	{
		return radious * radious * 3.14d;
	}
}
