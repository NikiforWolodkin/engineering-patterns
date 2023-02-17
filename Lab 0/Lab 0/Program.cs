using Lab_0;

Console.WriteLine(Lab_0.Math.Add(3, 8));
Console.WriteLine(Lab_0.Math.Add(3.5, 8));
Console.WriteLine(Lab_0.Math.Add("Hello", "World"));

List<int> ints = new List<int>();
List<double> doubles = new List<double>();
List<string> strings = new List<string>();
ints.Add(5);
Console.WriteLine(ints[0]);
doubles.Add(5);
Console.WriteLine(doubles[0]);
strings.Add("5");
Console.WriteLine(strings[0]);
Console.WriteLine();

List<Shape> shapes = new List<Shape>(new Shape[] {new Triangle(), new Square(), new Star()});
foreach (var shape in shapes)
{
    shape.DrawShape();
    Console.WriteLine();
}

Client client = new Client("Andrey");
client.Order("Oven");
Console.WriteLine(client.Orders[0]);

Admin admin = new Admin("Evgeniy", 45);
admin.SetPrice(50);
Console.WriteLine(admin.Price);
Console.WriteLine();

ListContainer listContainer = new ListContainer(3, 7);
ArrayContainer arrayContainer = new ArrayContainer(3, 7);
ValueContainer valueContainer = new ValueContainer(3, 7);
Console.WriteLine(listContainer.Sum());
Console.WriteLine(arrayContainer.Sum());
Console.WriteLine(valueContainer.Sum());