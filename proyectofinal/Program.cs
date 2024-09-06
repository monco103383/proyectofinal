using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool Continuar = true;
        List<string> listafactura = new List<string>();
        List<double> listaprecios = new List<double>();

        Console.WriteLine("Bienvenido al sistema de ventas La Colonia");
        Console.Write("Favor Ingrese su Nombre: ");
        string Nombre = Console.ReadLine();
        Console.Write("Favor Ingrese Edad: ");
        int Edad = Convert.ToInt32(Console.ReadLine());

        while (Continuar)
        {
            Console.WriteLine("Seleccione la Categoria del Producto a comprar");
            Console.WriteLine("1. Carnes");
            Console.WriteLine("2. Refrescos");
            Console.WriteLine("3. Frutas y verduras");

            string categoria = Console.ReadLine();
            double precio = 0;
            string prducto = "";
            int cantidad = 0;
            double total = 0;

            if (categoria == "1")
            {
                Console.WriteLine("Estos son todos los tipos de carne disponibles");
                Console.WriteLine("1. Tajo 120 Lps");
                Console.WriteLine("2. Bistec 95 Lps");
                Console.WriteLine("3. Pollo entero  70 Lps");
                Console.WriteLine("4. Filete 250 Lps");
                Console.WriteLine("5. Chuleta 200 Lps");
                Console.WriteLine("6. Carne molida 180 Lps");
                Console.WriteLine("7. Costilla 220 Lps");
                Console.WriteLine("8. Lomo 240 Lps");
                Console.WriteLine("9. Panceta 210 Lps");
                Console.WriteLine("10.pechuga de pollo 160 Lps");
                prducto = Console.ReadLine();

                if (prducto == "1") { precio = 120; }
                else if (prducto == "2")
                {
                    precio = 95;
                }
                else if (prducto == "3")
                {
                    precio = 70;
                }
                else if (prducto == "4")
                {
                    precio = 250;
                }
                else if (prducto == "5")
                {
                    precio = 200;
                }
                else if (prducto == "6")
                {
                    precio = 180;
                }
                else if (prducto == "7")
                {
                    precio = 220;
                }
                else if (prducto == "8")
                {
                    precio = 240;
                }
                else if (prducto == "9")
                {
                    precio = 210;
                }
                else if (prducto == "10")
                {
                    precio = 160;
                }
                else
                {
                    Console.WriteLine("No tenemos el producto seleccionado");
                    precio = 0;
                }
            }

            else if (categoria == "2")
            {
                Console.WriteLine("Estos son todos los tipos de refrescos disponibles");
                Console.WriteLine("1. Cocacola 25 Lps");
                Console.WriteLine("2. Pepsi 25 Lps");
                Console.WriteLine("3. Spryte 20 Lps");
                Console.WriteLine("4. Fanta 20 Lps");
                Console.WriteLine("5. Seven  22 Lps");
                Console.WriteLine("6. Banana Dew 25 Lps");
                Console.WriteLine("7. 7UP 22 Lps");
                Console.WriteLine("8. Mirinda 20 Lps");
                Console.WriteLine("9. Canadry 30 Lps");
                Console.WriteLine("10. Red bull 35 Lps");
                prducto = Console.ReadLine();

                if (prducto == "1") { precio = 25; }
                else if (prducto == "2")
                {
                    precio = 25;
                }
                else if (prducto == "3")
                {
                    precio = 20;
                }
                else if (prducto == "4")
                {
                    precio = 20;
                }
                else if (prducto == "5")
                {
                    precio = 22;
                }
                else if (prducto == "6")
                {
                    precio = 25;
                }
                else if (prducto == "7")
                {
                    precio = 22;
                }
                else if (prducto == "8")
                {
                    precio = 20;
                }
                else if (prducto == "9")
                {
                    precio = 30;
                }
                else if (prducto == "10")
                {
                    precio = 35;
                }
                else
                {
                    Console.WriteLine("No tenemos el producto seleccionado");
                    precio = 0;
                }
            }

            else if (categoria == "3")
            {
                Console.WriteLine("Estas son todas las frutas y verduras disponibles");
                Console.WriteLine("1. Manzana 30 Lps");
                Console.WriteLine("2. Plátano 15 Lps");
                Console.WriteLine("3. Naranja 20 Lps");
                Console.WriteLine("4. Mango 25 Lps");
                Console.WriteLine("5. Uva 35 Lps");
                Console.WriteLine("6. Pera 28 Lps");
                Console.WriteLine("7. Piña 40 Lps");
                Console.WriteLine("8. Sandia 50 Lps");
                Console.WriteLine("9. Papaya 45 Lps");
                Console.WriteLine("10. Limón 18 Lps");
                prducto = Console.ReadLine();

                if (prducto == "1") { precio = 30; }
                else if (prducto == "2")
                {
                    precio = 15;
                }
                else if (prducto == "3")
                {
                    precio = 20;
                }
                else if (prducto == "4")
                {
                    precio = 25;
                }
                else if (prducto == "5")
                {
                    precio = 35;
                }
                else if (prducto == "6")
                {
                    precio = 28;
                }
                else if (prducto == "7")
                {
                    precio = 40;
                }
                else if (prducto == "8")
                {

                    precio = 50;
                }
                else if (prducto == "9")
                {
                    precio = 45;
                }
                else if (prducto == "10")
                {
                    precio = 18;
                }
                else
                {
                    Console.WriteLine("No tenemos el producto seleccionado");
                    precio = 0;
                }
            }

            else
            {
                Console.WriteLine("Categoria no válida");
            }

            if (precio > 0)
            {
                Console.Write("Ingrese la cantidad que quier comprar: ");
                cantidad = Convert.ToInt32(Console.ReadLine());
                total = precio * cantidad;
                listafactura.Add($"{cantidad} de {prducto}");
                listaprecios.Add(total);

                Console.WriteLine("¿Quiere seguir comprando?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                string respuesta = Console.ReadLine();

                if (respuesta == "2")
                {
                    Continuar = false;
                    FacturaFinal(listafactura, listaprecios);
                }
            }
            else
            {
                Console.WriteLine("No se selecciono ningún producto válido.");
            }
        }
    }

    static void FacturaFinal(List<string> listafactura, List<double> listaprecios)
    {
        Console.Clear();
        Console.WriteLine("Factura Final");

        double totalFactura = 0;

        for (int i = 0; i < listafactura.Count; i++)
        {
            Console.WriteLine($"{listafactura[i]} ----- {listaprecios[i]} lrmpiras.");
            totalFactura += listaprecios[i];
        }

        Console.WriteLine($"Total a pagar: {totalFactura} lempiras.");
        Console.ReadKey();
    }
}