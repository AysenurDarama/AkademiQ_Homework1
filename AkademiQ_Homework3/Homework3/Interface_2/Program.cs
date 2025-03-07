/*  ABSTRACT CLASS                                              INTERFACE
   
 1- Hem gövdeli hem de soyut metotlar olabilir.	                1- Sadece imza.
 2-	Field tanımlanabilir.	                                    2- Field tanımlanamaz.
 3-	Bir sınıf yalnızca bir tane abstract sınıftan türeyebilir.	3- Bir sınıf birden fazla interface uygulayabilir.
 4-	Doğrudan nesne oluşturulamaz.	                            4- Doğrudan nesne oluşturulamaz.
 5-	Ortak özellikleri paylaşmak için kullanılır.	            5- Farklı sınıfların aynı metotları kullanmasını
                                                                  zorlamak için kullanılır.*/
using Interface_2;

IDrawable shape_1 = new Circle(2);
shape_1.Draw();
IAreaCalculate shape_2 = new Circle(2);
Console.WriteLine(shape_2.CalculateArea());

IDrawable[] drawableShapes = new IDrawable[]
        {
            new Circle(5),
            new Square(4),
            new Triangle(6, 3)
        };

IAreaCalculate[] calculableShapes = new IAreaCalculate[]
{
            new Circle(5),
            new Square(4),
            new Triangle(6, 3)
};

Console.WriteLine("Drawing Shapes:\n");
foreach (var shape in drawableShapes)
{
    shape.Draw();
}

Console.WriteLine("\nCalculating Areas:\n");
foreach (var shape in calculableShapes)
{
    Console.WriteLine($"Area: {shape.CalculateArea()}");
}
    