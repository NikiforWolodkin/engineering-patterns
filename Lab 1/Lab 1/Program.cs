using PP_Lab_1;

BasicClass basicClass1 = new BasicClass();
basicClass1.PrintMembers();
BasicClass basicClass2 = new BasicClass(2, 4, 6, 8, 10, 12);
basicClass2.PrintMembers();
BasicClass basicClass3 = new BasicClass(basicClass2);
basicClass3.PrintMembers();

basicClass1.PublicField = 16;
basicClass1.PublicProperty = 20;
basicClass1.PrintMembers();

basicClass1.PrintPublic();
basicClass1.CallPrivateAndProtectedMethods();

BasicClassWithInterface interfaceClass = new BasicClassWithInterface();

Subscriber subscriber1 = new Subscriber(8);
Subscriber subscriber2 = new Subscriber(3);
Subscriber subscriber3 = new Subscriber(20);
subscriber1.Subscribe(interfaceClass);
subscriber2.Subscribe(interfaceClass);
subscriber3.Subscribe(interfaceClass);

interfaceClass.List.Add(5);
interfaceClass.RaiseEvent();

foreach (var value in interfaceClass.List)
{
    Console.WriteLine(value);
}

Student student1 = new Student();
student1.PrintInfo();
Student student2 = new Student("Andrey", 20, "IT");
student2.PrintInfo();

student1.Faculty = "BIP";

Console.WriteLine(student2.IsStudying);
student2.Expell();
Console.WriteLine(student2.IsStudying);