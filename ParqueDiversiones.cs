using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class ParqueDiversiones
    {
        public static void Main(string[] args)
        {
            List<AtraccionMecanica> listaAtracciones = AdministradorArchivos.generarAtraccionesMecanicas();
            List<AtraccionAcuatica> listaAtracciones1 = AdministradorArchivos.generarAtraccionesAcuaticas();
            List<AtraccionVirtual> listaAtracciones2 = AdministradorArchivos.generarAtraccionesVirtuales();
            List<Empleado> ListaEmpleadosRegi = new List<Empleado>();
            //no está encontrando el texto de atracciones mecánicas


            int opcion;

            bool ret;




            do

            {
                MostrarMenu();

                do

                {
                    Console.WriteLine("Porfavor, ingrese una opcion valida");
                    ret = int.TryParse(Console.ReadLine(), out opcion);

                }

                while (!ret);

                switch (opcion)
                {
                    case 1:
                        RegistrarEmpleados(ListaEmpleadosRegi, listaAtracciones, listaAtracciones1, listaAtracciones2);
                        break;
                    case 2:
                        RegistrarNuevasAtracciones(listaAtracciones, listaAtracciones1, listaAtracciones2);
                        break;
                    case 3:
                     
                        break;
                    case 4:
               
                        break;
                    case 5:
                        
                        break;
                    case 6:
                      
                        break;
                    case 7:
                    
                        break;
                }
            }
            while (opcion != 0);


        }

        public static void MostrarMenu()
        {
            Console.WriteLine("       ░█████╗░████████╗██████╗░░█████╗░░█████╗░░█████╗░██╗░█████╗░███╗░░██╗███████╗░██████╗");
            Console.WriteLine("       ██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗░██║██╔════╝██╔════╝");
            Console.WriteLine("       ███████║░░░██║░░░██████╔╝███████║██║░░╚═╝██║░░╚═╝██║██║░░██║██╔██╗██║█████╗░░╚█████╗░");
            Console.WriteLine("       ██╔══██║░░░██║░░░██╔══██╗██╔══██║██║░░██╗██║░░██╗██║██║░░██║██║╚████║██╔══╝░░░╚═══██╗");
            Console.WriteLine("       ██║░░██║░░░██║░░░██║░░██║██║░░██║╚█████╔╝╚█████╔╝██║╚█████╔╝██║░╚███║███████╗██████╔╝");
            Console.WriteLine("       ╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚══════╝╚═════╝░");
            Console.WriteLine("        /   Seleccione una de las siguientes opciones:            \\          ");
            Console.WriteLine("       /   1. Registrar empleados.                                 \\         ");
            Console.WriteLine("      /    2. Registrar atracciones.                                \\        ");
            Console.WriteLine("     /     3. Crear cuentas bancarias.                               \\       ");
            Console.WriteLine("    /      4. Mostrar las cuentas bancarias.                          \\      ");
            Console.WriteLine("   /       5. Consignar dinero.                                        \\     ");
            Console.WriteLine("  /        6. Retirar dinero.                                           \\    ");
            Console.WriteLine(" /         7. Fin de mes.                                                \\   ");
            Console.WriteLine("/_________________________________________________________________________\\\n");


        }

        public static void RegistrarEmpleados(List<Empleado> ListaEmpleadosRegi, List<AtraccionMecanica> listaAtracciones, List<AtraccionAcuatica> listaAtracciones1, List<AtraccionVirtual> listaAtracciones2)
        {

            Console.WriteLine("¿Cuantos empleados desea registar?");
            int CantidadPersonas;
            bool tor = int.TryParse(Console.ReadLine(), out CantidadPersonas);
            for (int i = 0; i < CantidadPersonas; i++)
            {

                Console.WriteLine("Nombre completo de la persona: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su ID: ");
                string id = Console.ReadLine();
                
                Console.WriteLine($"{nombre}, ¿Que atraccion manejara?");
                Console.WriteLine("Ingrese el codigo de la ataccion: ");
                string codigoAtrac = Console.ReadLine();
                
                Atraccion atraccionManejar;
                if (listaAtracciones.Exists(x => x.Codigo == codigoAtrac))
                //if((listaAtracciones.Exists(x...)) or (listaAtracciones1.Exists(x...))or(listaAtracciones2.Exists(x..)))
                {

                    atraccionManejar = listaAtracciones.Find(x => x.Codigo == codigoAtrac);


                    Empleado empleadoX = new Empleado(id, nombre, atraccionManejar);

                    ListaEmpleadosRegi.Add(empleadoX);

                }

            }
        }

        public static void RegistrarNuevasAtracciones(List<AtraccionMecanica> listaAtracciones, List<AtraccionAcuatica> listaAtracciones1, List<AtraccionVirtual> listaAtracciones2)
        {

            int opcion;

            bool ret;
            
                    Console.WriteLine("¿Que tipo de atraccion desea crear?");
                    Console.WriteLine(" 1. Atraccion acuatica.");
                    Console.WriteLine(" 2. Atraccion mecanica.");
                    Console.WriteLine(" 3. Atraccion virtual.");
                    Console.WriteLine(" 4. Salir.");



            do

            {
                Console.WriteLine("Porfavor, ingrese una opcion valida");
                ret = int.TryParse(Console.ReadLine(), out opcion);

            }

            while (!ret);

            switch (opcion)
                {
                    case 1:
                    Console.WriteLine("¿Cuantas atracciones acuaticas desea crear?");
                    int CantidadAa;
                    bool tor = int.TryParse(Console.ReadLine(), out CantidadAa);
                    for (int i = 0; i < CantidadAa; i++)
                    {

                        string codigo;
                        string nombre;
                        int limite_edad;
                        float limite_estatura;
                        int costo;
                        Console.WriteLine("Codigo de la atraccion: ");
                        codigo = Console.ReadLine();
                        Console.WriteLine("Nombre de la atraccion: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("¿Cual es el limite de edad?");
                        bool limite_edad_aNum = int.TryParse(Console.ReadLine(), out limite_edad);
                        Console.WriteLine("¿Cual es el limite de estatura?");
                        bool limite_estatura_aNum = float.TryParse(Console.ReadLine(), out limite_estatura);
                        Console.WriteLine("¿Cual es el costo?");
                        bool costo_aNum = int.TryParse(Console.ReadLine(), out costo);
                        AtraccionAcuatica atraccionAcX = new AtraccionAcuatica(codigo, nombre, limite_edad, limite_estatura, costo);
                        listaAtracciones1.Add(atraccionAcX);
                    }
                        break;
                    case 2:
                    Console.WriteLine("¿Cuantas atracciones mecanicas desea crear?");
                    int CantidadAm;
                    bool tor2 = int.TryParse(Console.ReadLine(), out CantidadAm);
                    for (int i = 0; i < CantidadAm; i++)
                    {

                        string codigo;
                        string nombre;
                        int limite_edad;
                        float limite_estatura;
                        int costo;
                        Console.WriteLine("Codigo de la atraccion: ");
                        codigo = Console.ReadLine();
                        Console.WriteLine("Nombre de la atraccion: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("¿Cual es el limite de edad?");
                        bool limite_edad_aNum = int.TryParse(Console.ReadLine(), out limite_edad);
                        Console.WriteLine("¿Cual es el limite de estatura?");
                        bool limite_estatura_aNum = float.TryParse(Console.ReadLine(), out limite_estatura);
                        Console.WriteLine("¿Cual es el costo?");
                        bool costo_aNum = int.TryParse(Console.ReadLine(), out costo);
                        AtraccionMecanica atraccionAmX = new AtraccionMecanica(codigo, nombre, limite_edad,  limite_estatura, costo);
                        listaAtracciones.Add(atraccionAmX);
                    }
                    break;
                    case 3:
                    Console.WriteLine("¿Cuantas atracciones virtuales desea crear?");
                    int CantidadAv;
                    bool tor1 = int.TryParse(Console.ReadLine(), out CantidadAv);
                    for (int i = 0; i < CantidadAv; i++)
                    {

                        string codigo;
                        string nombre;
                        int limite_edad;
                        float limite_estatura;
                        int costo;
                        Console.WriteLine("Codigo de la atraccion: ");
                        codigo = Console.ReadLine();
                        Console.WriteLine("Nombre de la atraccion: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("¿Cual es el limite de edad?");
                        bool limite_edad_aNum = int.TryParse(Console.ReadLine(), out limite_edad);
                        Console.WriteLine("¿Cual es el limite de estatura?");
                        bool limite_estatura_aNum = float.TryParse(Console.ReadLine(), out limite_estatura);
                        Console.WriteLine("¿Cual es el costo?");
                        bool costo_aNum = int.TryParse(Console.ReadLine(), out costo);
                        AtraccionVirtual atraccionAvX = new AtraccionVirtual(codigo, nombre, limite_edad, limite_estatura, costo);
                        listaAtracciones2.Add(atraccionAvX);
                    }
                    break;

                    case 4:
                    Console.ReadLine();
                        break;
                }             
        }
    }
}
