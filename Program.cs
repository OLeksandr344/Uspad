
using uspadtask;


Circle c = new Circle();
Rectangle r = new Rectangle();
c.Radius = 10;
Console.WriteLine(c.CalculatePerimeter());
Console.WriteLine(c.CalculateArea());
r.Width = 10;
r.Height = 10;
Console.WriteLine(r.CalculateArea());
Console.WriteLine(r.CalculatePerimeter());
Apple apple = new Apple("Apple", "SOrt", "Red");
Pear pear = new Pear("Pear", "Grushaxd", "Green");
Console.WriteLine(apple.Name);
Console.WriteLine(pear.Name);
AnimalWithTail cat = new AnimalWithTail("Black", 4);
Console.WriteLine(cat.Color);
Dog doggie = new Dog("white", 5, 3);
Console.WriteLine(doggie.ToString());