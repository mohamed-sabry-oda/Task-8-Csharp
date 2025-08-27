using System;

namespace Task_8_Csharp
{
    internal class Program
    {
        #region Problem 7
        //public static void PrintTenShapes(IShapeSeries series)
        //{
        //    series.ResetSeries();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        series.GetNextArea();
        //        Console.WriteLine($"Shape {i + 1} Area = {series.CurrentShapeArea}");
        //    }
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Problem 1
            //IVehicle Car01 = new Car();
            //Car01.StartEngine();
            //IVehicle Bike01 = new Bike();
            //Bike01.StartEngine();
            //Bike01.StopEngine();
            #endregion


            #region Problem 2
            //Shape rec = new Rectangle(5,3);
            //rec.Display();
            //Shape cir = new Circle(10);
            //cir.Display();
            #endregion


            #region Problem 3
            //Product[] products = {
            //new Product(1,"A",500),
            //new Product(2,"B",200),
            //new Product(3,"C",100),
            //};
            //Console.WriteLine("Before Storing");

            //foreach (var p in products)
            //{
            //    Console.WriteLine(p);
            //}

            //Console.WriteLine("After sorting");

            //Array.Sort(products);

            //foreach (var p in products)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion


            #region Problem 4
            //Student StudentOne = new Student(1, "mohamed", 100);

            //// shallow copy
            //Student StudentTwo = StudentOne;
            //// Deep copy
            //Student StudentThree = new Student(StudentOne);

            //Console.WriteLine(StudentOne);
            //Console.WriteLine(StudentOne.GetHashCode());
            //Console.WriteLine(StudentTwo);
            //Console.WriteLine(StudentTwo.GetHashCode());
            //Console.WriteLine(StudentThree);
            //Console.WriteLine(StudentThree.GetHashCode());
            #endregion



            #region Problem 5
            //Robot r = new Robot();

            //r.Walk();   

            //IWalkable walker = r;
            //walker.Walk();
            #endregion



            #region Problem 6
            //Book BookOne = new Book();
            //Console.WriteLine(BookOne);

            //Book BookTwo = new Book("Story");
            //Console.WriteLine(BookTwo);

            //Book BookThree = new Book("Action", "Mohamed");
            //Console.WriteLine(BookThree);
            #endregion


            #region Problem 7
            //Console.WriteLine("Squares Series:");
            //PrintTenShapes(new SquareSeries());
            #endregion
        }
    }
}
