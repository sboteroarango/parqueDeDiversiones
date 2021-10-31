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
            List<AtraccionMecanica> listaAtraccionesMecanicas = AdministradorArchivos.generarAtraccionesMecanicas();
            List<AtraccionAcuatica> listaAtraccionesAcuaticas = AdministradorArchivos.generarAtraccionesAcuaticas();
            List<AtraccionVirtual> listaAtraccionesVirtuales = AdministradorArchivos.generarAtraccionesVirtuales();
            List<Empleado> ListaEmpleadosRegi = new List<Empleado>();
            List<Manilla> ListaManillasRegi = new List<Manilla>();
            Manilla prueba = new Manilla(46,1.73f,"Ivan",10000000);
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
                        RegistrarEmpleados(ListaEmpleadosRegi, listaAtraccionesMecanicas, listaAtraccionesAcuaticas, listaAtraccionesVirtuales);
                        break;
                    case 2:
                        RegistrarNuevasAtracciones(listaAtraccionesMecanicas, listaAtraccionesAcuaticas, listaAtraccionesVirtuales);
                        break;
                    case 3:
                        ComprarManilla(ListaManillasRegi);
                        break;
                    case 4:
                        RecargarManilla(ListaManillasRegi);
                        break;
                    case 5:
                        MostrarInfoAtrac(listaAtraccionesMecanicas, listaAtraccionesAcuaticas, listaAtraccionesVirtuales);
                        break;
                    case 6:
                        IngresarUsuarioAtraccion(ListaManillasRegi,listaAtraccionesMecanicas,listaAtraccionesAcuaticas,listaAtraccionesVirtuales);
                        break;
                    case 7:
                        break;
                    case 8:
                        GenerarReporteTotal(listaAtraccionesMecanicas,listaAtraccionesAcuaticas,listaAtraccionesVirtuales);
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
            Console.WriteLine("       ╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚══════╝╚═════╝░\n");
            Console.WriteLine("         /   Seleccione una de las siguientes opciones:            \\           ");
            Console.WriteLine("        /   1. Registrar empleados.                                 \\          ");
            Console.WriteLine("       /    2. Registrar atracciones.                                \\         ");
            Console.WriteLine("      /     3. Comprar manilla.                                       \\        ");
            Console.WriteLine("     /      4. Recargar la manilla.                                    \\       ");
            Console.WriteLine("    /       5. Consultar informacion de una atraccion.                  \\      ");
            Console.WriteLine("   /        6. Ingresar a una atraccion.                                 \\     ");
            Console.WriteLine("  /         7. Ver la informacion del usuario.                            \\    ");
            Console.WriteLine(" /          8. Generar reporte final.                                      \\   ");
            Console.WriteLine("/___________________________________________________________________________\\\n ");


        }

        public static void RegistrarEmpleados(List<Empleado> ListaEmpleadosRegi, List<AtraccionMecanica> listaAtraccionesMecanicas, List<AtraccionAcuatica> listaAtraccionesAcuaticas, List<AtraccionVirtual> listaAtraccionesVirtuales)
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
                if ((listaAtraccionesMecanicas.Exists(x => x.Codigo == codigoAtrac)) || (listaAtraccionesAcuaticas.Exists(x => x.Codigo == codigoAtrac)) || (listaAtraccionesVirtuales.Exists(x => x.Codigo == codigoAtrac)))
                
                {

                    atraccionManejar = listaAtraccionesMecanicas.Find(x => x.Codigo == codigoAtrac);
                    if (atraccionManejar == null)
                    {
                        atraccionManejar = listaAtraccionesAcuaticas.Find(x => x.Codigo == codigoAtrac);
                        if (atraccionManejar == null)
                        {
                            atraccionManejar = listaAtraccionesVirtuales.Find(x => x.Codigo == codigoAtrac);
                        }
                    }
                   

                    Empleado empleadoX = new Empleado(id, nombre, atraccionManejar);

                    ListaEmpleadosRegi.Add(empleadoX);

                }
                else
                {
                    Console.WriteLine("Esta atracción no fue encontrada");
                }

            }
        }

        public static void RegistrarNuevasAtracciones(List<AtraccionMecanica> listaAtraccionesMecanicas, List<AtraccionAcuatica> listaAtraccionesAcuaticas, List<AtraccionVirtual> listaAtraccionesVirtuales)
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
                        listaAtraccionesAcuaticas.Add(atraccionAcX);
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
                        listaAtraccionesMecanicas.Add(atraccionAmX);
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
                        listaAtraccionesVirtuales.Add(atraccionAvX);
                    }
                    break;

                    case 4:
                    Console.ReadLine();
                        break;
                }             
        }

        public static void MostrarInfoAtrac(List<AtraccionMecanica> listaAtraccionesMecanicas, List<AtraccionAcuatica> listaAtraccionesAcuaticas, List<AtraccionVirtual> listaAtraccionesVirtuales)
        {
            Console.WriteLine("Ingrese el codigo de la atraccion a informar: ");
            string codigoAtracInfo = Console.ReadLine();

            Atraccion atraccionInfo;

            if ((listaAtraccionesMecanicas.Exists(x => x.Codigo == codigoAtracInfo)) || (listaAtraccionesAcuaticas.Exists(x => x.Codigo == codigoAtracInfo)) || (listaAtraccionesVirtuales.Exists(x => x.Codigo == codigoAtracInfo)))
            {

                atraccionInfo = listaAtraccionesMecanicas.Find(x => x.Codigo == codigoAtracInfo);

                if(atraccionInfo == null)
                {
                    atraccionInfo = listaAtraccionesAcuaticas.Find(x => x.Codigo == codigoAtracInfo);

                    if(atraccionInfo == null)
                    {
                        atraccionInfo = listaAtraccionesVirtuales.Find(x => x.Codigo == codigoAtracInfo);
                        if (atraccionInfo == null)
                        {
                            Console.WriteLine("\nEl codigo ingresado no existe.\n");
                        }
                    }
                }
               
                


                string texto = atraccionInfo.GenerarStringConInfoDeAtraccion();

                Console.WriteLine(texto);


            }

            else
            {
                Console.WriteLine("\nEl codigo ingresado no existe.\n");
            }
            

        }
        public static void ComprarManilla(List<Manilla> ListaManillasRegi)
        {
            Console.WriteLine("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del usuario: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la estatura del usuario en metros (ejemplo : 1,80): ");
            float estatura = float.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese la cantidad a desembolsar a su manilla: ");
            int saldo = int.Parse(Console.ReadLine());
            Manilla manilla = new Manilla(edad,estatura,nombre,saldo);
            ListaManillasRegi.Add(manilla);
        
        }
        public static void RecargarManilla(List<Manilla> ListaManillasRegi)
        {
            Console.WriteLine("");
            for (int i = 0; i < ListaManillasRegi.Count; i++)
            {
                Console.WriteLine($"{i+1}. {ListaManillasRegi[i].Nombre_completo} - {ListaManillasRegi[i].Edad} años de edad - {ListaManillasRegi[i].Estatura} metros de estatura - {ListaManillasRegi[i].Saldo} pesos de saldo");
            }
            Console.WriteLine("");
            Console.WriteLine("Ingrese la manilla a recargar : ");
            int indiceDeManilla = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el saldo a recargar : ");
            int recargo = int.Parse(Console.ReadLine());
            ListaManillasRegi[indiceDeManilla-1].Recargar(recargo);
        }
    
        public static void GenerarReporteTotal(List<AtraccionMecanica> listaAtraccionesMecanicas, List<AtraccionAcuatica> listaAtraccionesAcuaticas, List<AtraccionVirtual> listaAtraccionesVirtuales)
        {
            Console.WriteLine("el Reporte aparecerá en el archivo reporte.txt");
            int ingresosTotales = 0;
            int ingresosEconomicosTotales = 0;
            foreach (Atraccion atraccion in listaAtraccionesMecanicas)
            {
                atraccion.GenerarReporte();
                ingresosTotales += (atraccion.Entradas).Count;
                foreach (Entrada entrada in atraccion.Entradas)
                {
                    ingresosEconomicosTotales += entrada.Costo;
                }
            }
            foreach (Atraccion atraccion in listaAtraccionesAcuaticas)
            {
                atraccion.GenerarReporte();
                ingresosTotales += (atraccion.Entradas).Count;
                foreach (Entrada entrada in atraccion.Entradas)
                {
                    ingresosEconomicosTotales += entrada.Costo;
                }
            }
            foreach (Atraccion atraccion in listaAtraccionesVirtuales)
            {
                atraccion.GenerarReporte();
                ingresosTotales += (atraccion.Entradas).Count;
                foreach (Entrada entrada in atraccion.Entradas)
                {
                    ingresosEconomicosTotales += entrada.Costo;
                }
            }
            DateTime ahora = DateTime.Now;
            TextWriter escritor = new StreamWriter("reporte.txt",append:true);
            escritor.WriteLine($"\nINGRESOS TOTALES : {ingresosTotales}\nINGRESOS ECONÓMICOS TOTALES: {ingresosEconomicosTotales}");
            escritor.Close();
        }
        public static void IngresarUsuarioAtraccion(List<Manilla> ListaManillasRegi, List<AtraccionMecanica> listaAtraccionesMecanicas, List<AtraccionAcuatica> listaAtraccionesAcuaticas, List<AtraccionVirtual> listaAtraccionesVirtuales)
        {
            Console.WriteLine("Usuarios registrados: ");
            for (int i = 0; i < ListaManillasRegi.Count; i++)
            {
                Console.WriteLine($"{i+1}. {ListaManillasRegi[i].Nombre_completo} - {ListaManillasRegi[i].Edad} años de edad - {ListaManillasRegi[i].Estatura} metros de estatura - {ListaManillasRegi[i].Saldo} pesos de saldo");
            }
            Console.WriteLine("");
            Console.WriteLine("ingrese el usuario que va a usar una atracción : ");
            int indiceDeManilla = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese código de la atracción a usar : ");
            string codigoAtrac = Console.ReadLine();
            Atraccion atraccionUsar;
            if ((listaAtraccionesMecanicas.Exists(x => x.Codigo == codigoAtrac)) || (listaAtraccionesAcuaticas.Exists(x => x.Codigo == codigoAtrac)) || (listaAtraccionesVirtuales.Exists(x => x.Codigo == codigoAtrac))) 
            {
                atraccionUsar = listaAtraccionesMecanicas.Find(x => x.Codigo == codigoAtrac);
                 if (atraccionUsar == null)
                {
                    atraccionUsar = listaAtraccionesAcuaticas.Find(x => x.Codigo == codigoAtrac);
                    if (atraccionUsar == null)
                    {
                        atraccionUsar = listaAtraccionesVirtuales.Find(x => x.Codigo == codigoAtrac);
                    }
                }

                atraccionUsar.SerUsada(ListaManillasRegi[indiceDeManilla-1]);
            }
            else 
            {
                Console.WriteLine("no se encontró la atracción");
            }



        }
    }
}
