using System;
using System.Collections.Generic;
using Entidades;
using ControlArchivos;

namespace Prueba_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializador<ControlListas<Cliente>> serializadorClientes = new Serializador<ControlListas<Cliente>>(ETipoExtenxion.Json);
            Serializador<ControlListas<Vehiculo>> serializadorVehiculos = new Serializador<ControlListas<Vehiculo>>(ETipoExtenxion.Json);

            ControlListas<Cliente> clientes = new ControlListas<Cliente>(new List<Cliente>()
            {
                new Cliente("25788814","Jose Luis","Cardenas","45859696"),
                new Cliente("16787414","Maria Luisa","Cardenas","45859696"),
                new Cliente("36258814","Esteban Javier","Viola","45859696"),
                new Cliente("41088800","Lorenzo Juan","Videla","45859696"),
                new Cliente("21588885","Luis Alberto","Alvarez","45859696"),
                new Cliente("42188854","Miguel Alberto","Lugo","45859696"),
                new Cliente("34788822","Mario Jose","Rivas","45859696"),
                new Cliente("45788815","Laura Edith","Perez","45859696"),
                new Cliente("35788810","Mariana Victoria","Gomez","45859696"),
                new Cliente("42088802","Cristina Celeste","Sanchez","45859696")
            });
            ControlListas<Vehiculo> vehiculos = new ControlListas<Vehiculo>(new List<Vehiculo>()
            {
                new Vehiculo("AA 458 BB",EClasificcacion.Economico,ConsoleColor.Green,false),
                new Vehiculo("AB 147 BC",EClasificcacion.Van,ConsoleColor.Gray,false),
                new Vehiculo("AE 325 CB",EClasificcacion.Mini,ConsoleColor.Green,false),
                new Vehiculo("AB 648 AD",EClasificcacion.Grande,ConsoleColor.DarkGray,false),
                new Vehiculo("AA 000 MN",EClasificcacion.Superior,ConsoleColor.Magenta,false),
                new Vehiculo("AA 222 CD",EClasificcacion.Economico,ConsoleColor.White,false),
                new Vehiculo("AC 215 MN",EClasificcacion.Mini,ConsoleColor.Gray,false),
                new Vehiculo("AB 658 KL",EClasificcacion.Grande,ConsoleColor.Yellow,false),
                new Vehiculo("AD 874 VG",EClasificcacion.Economico,ConsoleColor.Red,false),
                new Vehiculo("AF 882 SD",EClasificcacion.Superior,ConsoleColor.Black,false)
            });

            //try
            //{
            //    serializadorClientes.Escribir("clientes.xml", clientes);
            //    Console.WriteLine("\t << Escribir Clientes en XML >>");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error, {ex.Message}");
            //}

            try
            {
                serializadorClientes.Escribir("clientes.json", clientes);
                Console.WriteLine("\t << Escribir Clientes en json >>");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }

            try
            {
                serializadorVehiculos.Escribir("vehiculos.json", vehiculos);
                Console.WriteLine("\t << Escribir Vehiculos en JSON >>");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }

            //try
            //{
            //    serializadorVehiculos.Escribir("vehiculos.xml", vehiculos);
            //    Console.WriteLine("\t << Escribir Vehiculos en xml >>");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error, {ex.Message}");
            //}

            ControlListas<Cliente> clientes2 ;
            ControlListas<Vehiculo> vehiculos2;


            try
            {
                clientes2 = serializadorClientes.Leer("clientes.xml");
                Console.WriteLine("\t << Lectura Clientes en XML >>");
                foreach (Cliente item in clientes2.Lista)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }

            try
            {
                vehiculos2 = serializadorVehiculos.Leer("vehiculos.json");                
                Console.WriteLine("\t << Letura Vehiculos en JSON >>");
                foreach (Vehiculo item in vehiculos2.Lista)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }
           
            Console.ReadLine();
        }
    }
}
