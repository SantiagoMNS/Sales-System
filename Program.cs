using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
           Seller s1 = new Seller();
            s1.Name = "Santiago";
            s1.Age = 19;

            Seller s2 = new Seller();
            s2.Name = "Luis";
            s2.Age = 21;

            Seller s3 = new Seller();
            s3.Name = "Juan";
            s3.Age = 25;

            Product p1 = new Product();
            p1.Name = "Arroz";
            p1.Price = 500;

            Product p2 = new Product();
            p2.Name = "Panela";
            p2.Price = 300;

            Product p3 = new Product();
            p3.Name = "Frijoles";
            p3.Price = 150;

            Sale e1 = new Sale();
            e1.Product = "Venta N1";
            e1.Seller = "Santiago";
            e1.Comments = "Bien hecho";

            Sale e2 = new Sale();
            e2.Product = "Venta N2";
            e2.Seller = "Luis";
            e2.Comments = "Bien";

            Sale e3 = new Sale();
            e3.Product = "Venta N3";
            e3.Seller = "Juan";
            e3.Comments = "Hecho";


            double resultado;


            resultado = 500 + 300 + 150;

            System.Console.WriteLine("Resumen de la venta:" + e1.Product, e1.Seller, e1.Comments);
            System.Console.WriteLine("Nombre del vendedor:" + s1.Name, "Edad" + s1.Age);
            System.Console.WriteLine("Producto vendido:" + p1.Name);
            System.Console.WriteLine("Precio del prodcuto $ :" + p1.Price);

            System.Console.WriteLine();

            System.Console.WriteLine("Resumen de la venta:" + e2.Product, e2.Seller, e2.Comments);
            System.Console.WriteLine("Nombre del vendedor:" + s2.Name, "Edad" + s2.Age );
            System.Console.WriteLine("Producto vendido:" + p2.Name);
            System.Console.WriteLine("Precio del prodcuto $ :" + p2.Price);

            System.Console.WriteLine();

            System.Console.WriteLine("Resumen de la venta:" + e3.Product, e3.Seller, e3.Comments);
            System.Console.WriteLine("Nombre del vendedor:" + s3.Name, "Edad" + s3.Age);
            System.Console.WriteLine("Producto vendido:" + p3.Name);
            System.Console.WriteLine("Precio del prodcuto $ :" + p3.Price);

            System.Console.WriteLine();

            System.Console.WriteLine("Total vendido:" + resultado);

        }
    }
}
