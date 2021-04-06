using ColegioPF.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ColegioPF.Modelo;

namespace ColegioPF
{
    class Program
    {
        static Validaciones Vericar = new Validaciones();
        static List<Alumno> ListaAlumnos = new List<Alumno>();
        static List<Estudiantes> ListaAlumnosbd2 = new List<Estudiantes>();




        static void Main(string[] args)
        {
            int OpcMen;
            int numero;
            int opc1;
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();
            string temporal;

            do
            {
                bool EntradaValida = false;
                Console.Clear();
                gui.Marco(1, 119, 1, 5);
                gui.Marco(1, 119, 6, 29);
                gui.BorrarLinea(50, 22, 80);
                Console.SetCursorPosition(2, 2); Console.Write("App Estudiante ");
                Console.SetCursorPosition(2, 4); Console.Write("1. Agregar");
                Console.SetCursorPosition(21, 4); Console.Write("2. Listar");
                Console.SetCursorPosition(42, 4); Console.Write("3. Buscar");
                Console.SetCursorPosition(51, 15); Console.Write("BIENVENIDOS");
                Console.SetCursorPosition(2, 22); Console.Write(@"     _______. _______ .__   __.      ___      ");
                Console.SetCursorPosition(2, 23); Console.Write(@"    /       ||   ____||  \ |  |     /   \     ");
                Console.SetCursorPosition(2, 24); Console.Write(@"   |   (----`|  |__   |   \|  |    /  ^  \    ");
                Console.SetCursorPosition(2, 25); Console.Write(@"    \   \    |   __|  |  . `  |   /  /_\  \   ");
                Console.SetCursorPosition(2, 26); Console.Write(@".----)   |   |  |____ |  |\   |  /  _____  \  ");
                Console.SetCursorPosition(2, 27); Console.Write(@"|_______/    |_______||__| \__| /__/     \__\ ");
                Console.SetCursorPosition(2, 28); Console.Write(@"centro de mercados logistica y tecnologias de informacion");
                Console.SetCursorPosition(63, 4); Console.Write("4. Editar");
                Console.SetCursorPosition(84, 4); Console.Write("5. Borrar");
                Console.SetCursorPosition(105, 4); Console.Write("0. Salir");




                do
                {
                    gui.BorrarLinea(40, 16, 80);
                    Console.SetCursorPosition(75, 2); Console.Write("Escoja Opcion [ ]");
                    Console.SetCursorPosition(90, 2);
                    temporal =  Console.ReadLine();
                    
                    if (!Vericar.Vacio(temporal))
                        if (Vericar.TipoNumero(temporal))
                            EntradaValida = true;
                } while (!EntradaValida);

                

                
                
                OpcMen = Convert.ToInt32(temporal);

                switch (OpcMen)
                {
                    case 1:
                        InsertarNombre();
                        break;
                    case 2:
                        ListarNombres();
                        break;
                    case 3:
                        BuscarNombre();
                        break;
                    /*case 4:
                        LeerArchivoXml();
                        break;*/
                    /*case 5:
                        EscrirArchivoXml();
                        break;*/
                    case 0:
                        gui.BorrarLinea(40, 22, 80);
                        break;
                    case 5:
                        Eliminar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    default:
                        {
                            gui.BorrarLinea(40, 22, 80);
                            gui.BorrarLinea(2, 22, 80);
                            gui.BorrarLinea(2, 23, 80);
                            gui.BorrarLinea(2, 24, 80);
                            gui.BorrarLinea(2, 25, 80);
                            gui.BorrarLinea(2, 26, 80);
                            gui.BorrarLinea(2, 27, 80);
                            gui.BorrarLinea(2, 28, 80);
                            gui.BorrarLinea(1, 15, 100);
                            gui.Marco2(36, 86, 13, 17);
                            
                            Console.SetCursorPosition(51, 15); Console.Write(" Opcion Invalida");
                            Console.ReadLine();
                        }
                        break;

                }
                gui.BorrarLinea(40, 23, 80);
                //Console.SetCursorPosition(40, 23); Console.Write("presione cualquier tecla para continuar");
                //Console.ReadKey();
            } while (OpcMen != 0);
            gui.BorrarLinea(1, 15, 100);
            gui.Marco2(36, 86, 13, 17);

            Console.SetCursorPosition(51, 15); Console.Write("Gracias vuelva pronto");
            Console.ReadLine();
            


        }
        static void InsertarNombre()
        {
            var db = new taller_netContext();
            ListaAlumnosbd2 = db.Estudiantes.ToList();
            string preg = "s";

            do
            {
                bool EntradaValidaNombre = false;
                bool EntradaValidaCodigo = false;
                bool EntradaValidacorreo = false;
                bool EntradaValidaNota1 = false;
                bool EntradaValidaNota2 = false;
                bool EntradaValidaNota3 = false;
                bool EntradaValidaCaja = false;

                string codigo;
                string nombre;
                string correo;
                string nota1;
                string nota2;
                string nota3;
                string caja;

                Console.Clear();
                gui.Marco(1, 119, 1, 5);
                gui.Marco(1, 119, 6, 29);
                gui.BorrarLinea(50, 22, 80);
                Console.SetCursorPosition(2, 2); Console.Write("App Estudiante ");
                Console.SetCursorPosition(2, 4); Console.Write("1. Agregar");
                Console.SetCursorPosition(21, 4); Console.Write("2. Listar");
                Console.SetCursorPosition(42, 4); Console.Write("3. Buscar");
                Console.SetCursorPosition(63, 4); Console.Write("4. Editar");
                Console.SetCursorPosition(84, 4); Console.Write("5. Borrar");
                Console.SetCursorPosition(105, 4); Console.Write("0. Salir");
                Console.SetCursorPosition(75, 2); Console.Write("Escoja Opcion [ ]");
                Console.SetCursorPosition(51, 8); Console.WriteLine("AGREGAR ESTUDIANTE");
                



                do
                {
                    gui.BorrarLinea(73, 12, 119);
                    gui.Marco3(36, 86, 20, 24);
                    gui.Marco3(36, 86, 20, 24);
                    gui.BorrarLinea(35, 22, 119);
                    Console.SetCursorPosition(51, 12); Console.Write("Digite el Codigo    : ");
                    Console.SetCursorPosition(73, 12);
                    codigo = Console.ReadLine();
                    if (!Vericar.Vacio(codigo))
                        if (Vericar.TipoNumero(codigo))
                            if (Convert.ToDouble(codigo) > 999 && Convert.ToDouble(codigo) <= 9999)
                            {
                                EntradaValidaCodigo = true;
                            }
                            else
                            {
                                gui.BorrarLinea(40, 22, 80);
                                gui.Marco2(36, 86, 20, 24);
                                Console.SetCursorPosition(40, 22);
                                Console.Write("El codigo debe tener cuatro (4) digitos!");
                                Console.ReadLine();
                            }
                    
                } while (!EntradaValidaCodigo);

                if (!Existe(Convert.ToInt32(codigo)))
                {
                    do
                    {
                        gui.BorrarLinea(73, 13, 119);
                        gui.Marco3(36, 86, 20, 24);
                        gui.Marco3(36, 90, 20, 24);
                        gui.BorrarLinea(45, 22, 119);
                        Console.SetCursorPosition(51, 13); Console.Write("Digite el Nombre    : ");
                        Console.SetCursorPosition(73, 13);
                        nombre = Console.ReadLine();
                        if (!Vericar.Vacio(nombre))
                            if (Vericar.TipoTexto(nombre))
                                EntradaValidaNombre = true;
                    } while (!EntradaValidaNombre);

                    do
                    {
                        gui.BorrarLinea(73, 14, 119);
                        gui.Marco3(36, 86, 20, 24);
                        gui.BorrarLinea(20, 22, 119);
                        Console.SetCursorPosition(51, 14); Console.Write("Digite el Correo    : ");
                        Console.SetCursorPosition(73, 14);
                        correo = Console.ReadLine();
                        if (!Vericar.Vacio(correo))
                            if (Vericar.TipoCorreo(correo))
                                EntradaValidacorreo = true;
                    } while (!EntradaValidacorreo);

                    do
                    {
                        gui.BorrarLinea(73, 15, 119);
                        gui.Marco3(36, 86, 20, 24);
                        gui.BorrarLinea(20, 22, 119);
                        Console.SetCursorPosition(51, 15); Console.Write("Digite la nota 1    : ");
                        Console.SetCursorPosition(73, 15);
                        nota1 = Console.ReadLine();
                        if (!Vericar.Vacio(nota1))
                            if (Vericar.TipoNumero(nota1))
                                if (Convert.ToDouble(nota1) >= 0 && Convert.ToDouble(nota1) <= 5)
                                {
                                    EntradaValidaNota1 = true;
                                }
                                else
                                {
                                    gui.BorrarLinea(40, 22, 80);
                                    gui.Marco2(36, 86, 20, 24);
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("La nota debe estar entre 0 y 5");
                                    Console.ReadLine();
                                }
                    } while (!EntradaValidaNota1);

                    do
                    {
                        gui.BorrarLinea(73, 16, 119);
                        gui.Marco3(36, 86, 20, 24);
                        gui.BorrarLinea(20, 22, 119);
                        Console.SetCursorPosition(51, 16); Console.Write("Digite la nota 2    : ");
                        nota2 = Console.ReadLine();
                        Console.SetCursorPosition(73, 16);
                        if (!Vericar.Vacio(nota2))
                            if (Vericar.TipoNumero(nota2))
                                if (Convert.ToDouble(nota2) >= 0 && Convert.ToDouble(nota2) <= 5)
                                {
                                    EntradaValidaNota2 = true;
                                }
                                else
                                {
                                    gui.BorrarLinea(40, 22, 80);
                                    gui.Marco2(36, 86, 20, 24);
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("La nota debe estar entre 0 y 5");
                                    Console.ReadLine();
                                }

                    } while (!EntradaValidaNota2);

                    do
                    {
                        gui.BorrarLinea(73, 17, 119);
                        gui.Marco3(36, 86, 20, 24);
                        gui.BorrarLinea(20, 22, 119);
                        Console.SetCursorPosition(51, 17); Console.Write("Digite la nota 3    : ");
                        Console.SetCursorPosition(73, 17);
                        nota3 = Console.ReadLine();
                        if (!Vericar.Vacio(nota3))
                            if (Vericar.TipoNumero(nota3))
                                if (Convert.ToDouble(nota3) >= 0 && Convert.ToDouble(nota3) <= 5)
                                {
                                    EntradaValidaNota3 = true;
                                }
                                else
                                {
                                    gui.BorrarLinea(40, 22, 80);
                                    gui.Marco2(36, 86, 20, 24);
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("La nota debe estar entre 0 y 5");
                                    Console.ReadLine();
                                }
                    } while (!EntradaValidaNota3);


                    //..........................................




                    Estudiantes estudiante = new Estudiantes();
                    Alumno myAlumno = new Alumno();
                    estudiante.Codigo = Convert.ToInt32(codigo);
                    estudiante.Nombre = nombre;
                    estudiante.Correo = correo;
                    estudiante.Nota1 = Convert.ToDouble(nota1);
                    estudiante.Nota2 = Convert.ToDouble(nota2);
                    estudiante.Nota3 = Convert.ToDouble(nota3);
                    estudiante.NotaDef = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2) + Convert.ToDouble(nota3)) / 3;


                    if (estudiante.NotaDef >= 3.5)
                    {
                        estudiante.Definitiva = "Aprobado";
                    }
                    else
                    {
                        estudiante.Definitiva = "Reprobado";
                    }


                    db.Estudiantes.Add(estudiante);
                    
                    db.SaveChanges();

                }
                else
                {
                    gui.BorrarLinea(40, 22, 80);
                    gui.Marco2(35, 95, 20, 24);
                    Console.SetCursorPosition(40, 22);
                    Console.WriteLine("El usuario con el codigo " + codigo + " Ya Existe en el sistema");
                    preg = "n";
                    Console.ReadLine();


                }

                gui.Marco3(35, 95, 20, 24);
                gui.BorrarLinea(40, 22, 80);
                gui.Marco2(19, 107, 20, 24);
                Console.SetCursorPosition(20, 22);
                Console.Write("Pulse cualquier tecla para seguir agregando estudiantes o de lo contrario pulse n/N: ");
                preg = Console.ReadLine();
            } while (preg != "n" && preg != "N");
        }

        static void ListarNombres()
        {
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();
            Console.Clear();
            gui.Marco(1, 119, 1, 5);
            gui.Marco(1, 119, 6, 29);
            gui.BorrarLinea(50, 22, 80);
            Console.SetCursorPosition(2, 2); Console.Write("App Estudiante ");
            Console.SetCursorPosition(2, 4); Console.Write("1. Agregar");
            Console.SetCursorPosition(21, 4); Console.Write("2. Listar");
            Console.SetCursorPosition(42, 4); Console.Write("3. Buscar");
            Console.SetCursorPosition(63, 4); Console.Write("4. Editar");
            Console.SetCursorPosition(84, 4); Console.Write("5. Borrar");
            Console.SetCursorPosition(105, 4); Console.Write("0. Salir");
            Console.SetCursorPosition(75, 2); Console.Write("Escoja Opcion [ ]");
            Console.SetCursorPosition(51, 8); Console.WriteLine("LISTA DE ESTUDIANTES");
            Console.SetCursorPosition(40, 2); Console.Write(" Cantidad de Alumnos: " + ListaAlumnosbd.Count);
            int altura = 10;
            
            gui.Linea2(10, 22, 18);
            gui.Linea2(10, 22, 33);
            gui.Linea2(10, 22, 52);
            gui.Linea2(10, 22, 63);
            gui.Linea2(10, 22, 73);
            gui.Linea2(10, 22, 82);
            gui.Linea2(10, 22, 97);

            Console.SetCursorPosition(8, 9); Console.Write("CODIGO");
            Console.SetCursorPosition(23, 9); Console.Write("NOMBRES");
            Console.SetCursorPosition(39, 9); Console.Write("CORREO");
            Console.SetCursorPosition(55, 9); Console.Write("NOTA 1");
            Console.SetCursorPosition(66, 9); Console.Write("NOTA 2");
            Console.SetCursorPosition(75, 9); Console.Write("NOTA 3");
            Console.SetCursorPosition(85, 9); Console.Write("NOTA FINAL");
            Console.SetCursorPosition(103, 9); Console.Write("CONCEPTO");


            foreach (var ObjetoAlumno in ListaAlumnosbd)
            {


                Console.SetCursorPosition(9, altura); Console.Write(ObjetoAlumno.Codigo);
                Console.SetCursorPosition(19, altura); Console.Write(ObjetoAlumno.Nombre);
                Console.SetCursorPosition(34, altura); Console.Write(ObjetoAlumno.Correo);
                Console.SetCursorPosition(57, altura); Console.Write("{0:N1}", ObjetoAlumno.Nota1);
                Console.SetCursorPosition(67, altura); Console.Write("{0:N1}", ObjetoAlumno.Nota2);
                Console.SetCursorPosition(77, altura); Console.Write("{0:N1}", ObjetoAlumno.Nota3);
                Console.SetCursorPosition(87, altura); Console.Write("{0:N2}", ObjetoAlumno.NotaDef);
                Console.SetCursorPosition(104, altura); Console.Write(ObjetoAlumno.Definitiva);

                altura++;
            }
            Console.SetCursorPosition(38, 29);
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.SetCursorPosition(74, 29);
            Console.ReadLine();
        }

        static void BuscarNombre()
        {
            string codigo;
            bool EntradaValidaCodigo = false;

            Console.Clear();
            gui.Marco(1, 119, 1, 5);
            gui.Marco(1, 119, 6, 29);
            gui.BorrarLinea(50, 22, 80);
            Console.SetCursorPosition(2, 2); Console.Write("App Estudiante ");
            Console.SetCursorPosition(2, 4); Console.Write("1. Agregar");
            Console.SetCursorPosition(21, 4); Console.Write("2. Listar");
            Console.SetCursorPosition(42, 4); Console.Write("3. Buscar");
            Console.SetCursorPosition(63, 4); Console.Write("4. Editar");
            Console.SetCursorPosition(84, 4); Console.Write("5. Borrar");
            Console.SetCursorPosition(105, 4); Console.Write("0. Salir");
            Console.SetCursorPosition(75, 2); Console.Write("Escoja Opcion [ ]");
            
            gui.Linea(40, 6, 30);

            do // pedir el codigo
            {
                gui.BorrarLinea(34, 8, 64);
                Console.SetCursorPosition(8, 10); Console.Write("CODIGO DEL ESTUDIANTE A BUSCAR [      ] ");
                Console.SetCursorPosition(41, 10); codigo = Console.ReadLine();
                if (!Vericar.Vacio(codigo))
                    if (Vericar.TipoNumero(codigo))
                        EntradaValidaCodigo = true;
            } while (!EntradaValidaCodigo);

            if (Existe(Convert.ToInt32(codigo)))
            {
                Estudiantes myAlumno = ObtenerDatos(Convert.ToInt32(codigo));

                int altura = 11;
                

                Console.SetCursorPosition(8 , 14); Console.Write("CODIGO     :");
                Console.SetCursorPosition(8, 15); Console.Write("NOMBRES     :");
                Console.SetCursorPosition(8, 16); Console.Write("CORREO      :");
                Console.SetCursorPosition(8, 17); Console.Write("NOTA 1      :");
                Console.SetCursorPosition(8, 18); Console.Write("NOTA 2      :");
                Console.SetCursorPosition(8, 19); Console.Write("NOTA 3      :");
                Console.SetCursorPosition(8, 20); Console.Write("NOTA FINAL  :");
                Console.SetCursorPosition(8, 21); Console.Write("CONCEPTO    :");

                Console.SetCursorPosition(22, 14); Console.Write(myAlumno.Codigo);
                Console.SetCursorPosition(22, 15); Console.Write(myAlumno.Nombre);
                Console.SetCursorPosition(22, 16); Console.Write(myAlumno.Correo);
                Console.SetCursorPosition(22, 17); Console.Write("{0:N1}", myAlumno.Nota1);
                Console.SetCursorPosition(22, 18); Console.Write("{0:N1}", myAlumno.Nota2);
                Console.SetCursorPosition(22, 19); Console.Write("{0:N1}", myAlumno.Nota3);
                Console.SetCursorPosition(22, 20); Console.Write("{0:N2}", myAlumno.NotaDef);
                Console.SetCursorPosition(22, 21); Console.Write(myAlumno.Definitiva);

            }
            else
            {
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 22); Console.Write(" El usuario del codigo " + codigo + " No existe");
            }
            Console.SetCursorPosition(38, 29);
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.SetCursorPosition(74, 29);
            Console.ReadLine();

        }

        static void Modificar()
        {
            string codigo;
            
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();
            string cod;

            string nombre;
            string correo;
            string nota1;
            string nota2;
            string nota3;
            string caja;

            bool EntradaValidaNombre = false;
            bool EntradaValidaCodigo = false;
            bool EntradaValidacorreo = false;
            bool EntradaValidaNota1 = false;
            bool EntradaValidaNota2 = false;
            bool EntradaValidaNota3 = false;
            bool EntradaValidaCaja = false;


            Console.Clear();
            gui.Marco(1, 119, 1, 5);
            gui.Marco(1, 119, 6, 29);
            gui.BorrarLinea(50, 22, 80);
            Console.SetCursorPosition(2, 2); Console.Write("App Estudiante ");
            Console.SetCursorPosition(2, 4); Console.Write("1. Agregar");
            Console.SetCursorPosition(21, 4); Console.Write("2. Listar");
            Console.SetCursorPosition(42, 4); Console.Write("3. Buscar");
            Console.SetCursorPosition(63, 4); Console.Write("4. Editar");
            Console.SetCursorPosition(84, 4); Console.Write("5. Borrar");
            Console.SetCursorPosition(105, 4); Console.Write("0. Salir");
            Console.SetCursorPosition(75, 2); Console.Write("Escoja Opcion [ ]");
            Console.SetCursorPosition(51, 8); Console.WriteLine("AGREGAR ESTUDIANTE");

            do // pedir el codigo
            {
                gui.BorrarLinea(34, 8, 64);
                Console.SetCursorPosition(8, 10); Console.Write("CODIGO DEL ESTUDIANTE A EDITAR [      ]");
                Console.SetCursorPosition(41, 10); cod = Console.ReadLine();
                if (!Vericar.Vacio(cod))
                    if (Vericar.TipoNumero(cod))
                        EntradaValidaCodigo = true;
            } while (!EntradaValidaCodigo);

            if (Existe(Convert.ToInt32(cod)))
            {
                Estudiantes myAlumno = ObtenerDatos(Convert.ToInt32(cod));
                int posicion = Posicion(Convert.ToInt32(cod));
                int altura = 11;
          
                Console.SetCursorPosition(8, 14); Console.Write("CODIGO      :");
                Console.SetCursorPosition(8, 15); Console.Write("NOMBRES     :");
                Console.SetCursorPosition(8, 16); Console.Write("CORREO      :");
                Console.SetCursorPosition(8, 17); Console.Write("NOTA 1      :");
                Console.SetCursorPosition(8, 18); Console.Write("NOTA 2      :");
                Console.SetCursorPosition(8, 19); Console.Write("NOTA 3      :");
                Console.SetCursorPosition(8, 20); Console.Write("NOTA FINAL  :");
                Console.SetCursorPosition(8, 21); Console.Write("CONCEPTO   :");

                Console.SetCursorPosition(22, 14); Console.Write(myAlumno.Codigo);
                Console.SetCursorPosition(22, 15); Console.Write(myAlumno.Nombre);
                Console.SetCursorPosition(22, 16); Console.Write(myAlumno.Correo);
                Console.SetCursorPosition(22, 17); Console.Write("{0:N1}", myAlumno.Nota1);
                Console.SetCursorPosition(22, 18); Console.Write("{0:N1}", myAlumno.Nota2);
                Console.SetCursorPosition(22, 19); Console.Write("{0:N1}", myAlumno.Nota3);
                Console.SetCursorPosition(22, 20); Console.Write("{0:N2}", myAlumno.NotaDef);
                Console.SetCursorPosition(22, 21); Console.Write(myAlumno.Definitiva);

                do
                {
                    gui.Marco3(36, 90, 20, 24);
                    gui.BorrarLinea(20, 22, 119);
                    gui.BorrarLinea(73, 15, 119);
                    Console.SetCursorPosition(51, 15); Console.Write("Digite el Nombre    : ");
                    Console.SetCursorPosition(73, 15);
                    nombre = Console.ReadLine();
                    if (nombre.Equals(""))
                    {
                        nombre = myAlumno.Nombre;
                        EntradaValidaNombre = true;
                    }
                    else {
                        if (!Vericar.Vacio(nombre))
                            if (Vericar.TipoTexto(nombre))
                                EntradaValidaNombre = true;
                    }
                } while (!EntradaValidaNombre);

                do
                {
                    gui.Marco3(36, 86, 20, 24);
                    gui.BorrarLinea(20, 22, 119);
                    gui.BorrarLinea(73, 16, 119);
                    Console.SetCursorPosition(51, 16); Console.Write("Digite el Correo    : ");
                    Console.SetCursorPosition(73, 16);
                    correo = Console.ReadLine();
                    if (correo.Equals(""))
                    {
                        correo = myAlumno.Correo;
                        EntradaValidacorreo = true;
                    }
                    else
                    {
                        if (!Vericar.Vacio(correo))
                            if (Vericar.TipoCorreo(correo))
                                EntradaValidacorreo = true;
                    }
                } while (!EntradaValidacorreo);

                do
                {
                    gui.Marco3(36, 86, 20, 24);
                    gui.BorrarLinea(20, 22, 119);
                    gui.BorrarLinea(73, 17, 119);
                    Console.SetCursorPosition(51, 17); Console.Write("Digite la nota 1    : ");
                    Console.SetCursorPosition(73, 17);
                    nota1 = Console.ReadLine();
                    
                    if (nota1.Equals(""))
                    {
                        
                        nota1 = myAlumno.Nota1.ToString();
                        EntradaValidaNota1 = true;
                    }
                    else
                    {
                        if (!Vericar.Vacio(nota1))
                            if (Vericar.TipoNumero(nota1))
                                if (Convert.ToDouble(nota1) >= 0 && Convert.ToDouble(nota1) <= 5)
                                {
                                    EntradaValidaNota1 = true;
                                }
                                else
                                {
                                    gui.BorrarLinea(40, 22, 64);
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("La nota debe estar entre 0 y 5");
                                }
                    }
                } while (!EntradaValidaNota1);

                do
                {
                    gui.Marco3(36, 86, 20, 24);
                    gui.BorrarLinea(20, 22, 119);
                    gui.BorrarLinea(73, 18, 119);
                    Console.SetCursorPosition(51, 18); Console.Write("Digite la nota 2    : ");
                    nota2 = Console.ReadLine();
                    Console.SetCursorPosition(73, 18);
                    if (nota2.Equals(""))
                    {

                        nota2 = myAlumno.Nota2.ToString();
                        EntradaValidaNota2 = true;
                    }
                    else
                    {
                        if (!Vericar.Vacio(nota2))
                            if (Vericar.TipoNumero(nota2))
                                if (Convert.ToDouble(nota2) >= 0 && Convert.ToDouble(nota2) <= 5)
                                {
                                    EntradaValidaNota2 = true;
                                }
                                else
                                {
                                    gui.BorrarLinea(40, 22, 64);
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("La nota debe estar entre 0 y 5");
                                }
                    }
                } while (!EntradaValidaNota2);

                do
                {
                    gui.Marco3(36, 86, 20, 24);
                    gui.BorrarLinea(20, 22, 119);
                    gui.BorrarLinea(73, 19, 119);
                    Console.SetCursorPosition(51, 19); Console.Write("Digite la nota 3    : ");
                    Console.SetCursorPosition(73, 19);
                    nota3 = Console.ReadLine();
                    if (nota3.Equals(""))
                    {

                        nota3 = myAlumno.Nota3.ToString();
                        EntradaValidaNota3 = true;
                    }
                    else
                    {
                        if (!Vericar.Vacio(nota3))
                            if (Vericar.TipoNumero(nota3))
                                if (Convert.ToDouble(nota3) >= 0 && Convert.ToDouble(nota3) <= 5)
                                {
                                    EntradaValidaNota3 = true;
                                }
                                else
                                {
                                    gui.BorrarLinea(40, 22, 64);
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("La nota debe estar entre 0 y 5");
                                }
                    }
                } while (!EntradaValidaNota3);

                //..........................................



                int cod2 = Convert.ToInt32(cod);

                    myAlumno = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod2);
                    //myAlumno.Codigo = Convert.ToInt32(codigo);
                    myAlumno.Nombre = nombre;
                    myAlumno.Correo = correo;
                    myAlumno.Nota1 = Convert.ToDouble(nota1);
                    myAlumno.Nota2 = Convert.ToDouble(nota2);
                    myAlumno.Nota3 = Convert.ToDouble(nota3);
                    myAlumno.NotaDef = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2) + Convert.ToDouble(nota3)) / 3;


                    if (myAlumno.NotaDef >= 3.5)
                    {
                        myAlumno.Definitiva = "Aprobado";
                    }
                    else
                    {
                        myAlumno.Definitiva = "Reprobado";
                    }

                    db.SaveChanges();

                

            }
            else
            {
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 22); Console.Write(" El usuario del codigo " + cod + " No existe");
            }
            gui.BorrarLinea(40, 22, 80);
            gui.Marco2(36, 86, 20, 24);
            Console.SetCursorPosition(40, 21);Console.WriteLine("Estudiante editado correctamente!");
            Console.SetCursorPosition(40, 22);Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.SetCursorPosition(78, 22);
            Console.ReadLine();




        }


        static void InsertarNombreModificar(int pos)
        {
            bool EntradaValidaNombre = false;
            bool EntradaValidaCodigo = false;
            bool EntradaValidacorreo = false;
            bool EntradaValidaNota1 = false;
            bool EntradaValidaNota2 = false;
            bool EntradaValidaNota3 = false;
            bool EntradaValidaCaja = false;

            string codigo;
            string nombre;
            string correo;
            string nota1;
            string nota2;
            string nota3;
            string caja;

            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();


            gui.Marco(1, 119, 1, 25);
            Console.SetCursorPosition(20, 7); Console.WriteLine("Alumno a modificarrrr");
            gui.Linea(40, 6, 30);



            do
            {
                gui.BorrarLinea(34, 13, 64);
                Console.SetCursorPosition(10, 13); Console.Write("Digite nuevo Codigo del Alumno: ");
                codigo = Console.ReadLine();
                if (!Vericar.Vacio(codigo))
                    if (Vericar.TipoNumero(codigo))
                        EntradaValidaCodigo = true;
            } while (!EntradaValidaCodigo);


            do
            {
                gui.BorrarLinea(33, 14, 64);
                Console.SetCursorPosition(10, 14); Console.Write("Digite Nombres Alumno:");
                nombre = Console.ReadLine();
                if (!Vericar.Vacio(nombre))
                    if (Vericar.TipoTexto(nombre))
                        EntradaValidaNombre = true;
            } while (!EntradaValidaNombre);

            do
            {
                gui.BorrarLinea(37, 15, 64);
                Console.SetCursorPosition(10, 15); Console.Write("Digite correo: ");
                correo = Console.ReadLine();
                if (!Vericar.Vacio(correo))
                    if (Vericar.TipoTexto(correo))
                        EntradaValidacorreo = true;
            } while (!EntradaValidacorreo);

            do
            {
                gui.BorrarLinea(28, 16, 64);
                Console.SetCursorPosition(10, 16); Console.Write("Digite la nota 1: ");
                nota1 = Console.ReadLine();
                if (!Vericar.Vacio(nota1))
                    if (Vericar.TipoNumero(nota1))
                        if (Convert.ToDouble(nota1) >= 0 && Convert.ToDouble(nota1) <= 5)
                        {
                            EntradaValidaNota1 = true;
                        }
                        else
                        {
                            gui.BorrarLinea(40, 22, 64);
                            Console.SetCursorPosition(40, 22);
                            Console.Write("La nota debe estar entre 0 y 5");
                        }
            } while (!EntradaValidaNota1);

            do
            {
                gui.BorrarLinea(28, 17, 64);
                Console.SetCursorPosition(10, 17); Console.Write("Digite la nota 2: ");
                nota2 = Console.ReadLine();
                if (!Vericar.Vacio(nota2))
                    if (Vericar.TipoNumero(nota2))
                        if (Convert.ToDouble(nota2) >= 0 && Convert.ToDouble(nota2) <= 5)
                        {
                            EntradaValidaNota2 = true;
                        }
                        else
                        {
                            gui.BorrarLinea(40, 22, 64);
                            Console.SetCursorPosition(40, 22);
                            Console.Write("La nota debe estar entre 0 y 5");
                        }

            } while (!EntradaValidaNota2);

            do
            {
                gui.BorrarLinea(28, 18, 64);
                Console.SetCursorPosition(10, 18); Console.Write("Digite la nota 3: ");
                nota3 = Console.ReadLine();
                if (!Vericar.Vacio(nota3))
                    if (Vericar.TipoNumero(nota3))
                        if (Convert.ToDouble(nota3) >= 0 && Convert.ToDouble(nota3) <= 5)
                        {
                            EntradaValidaNota3 = true;
                        }
                        else
                        {
                            gui.BorrarLinea(40, 22, 64);
                            Console.SetCursorPosition(40, 22);
                            Console.Write("La nota debe estar entre 0 y 5");
                        }
            } while (!EntradaValidaNota3);


            //..........................................





            var myAlumno = new Estudiantes();
            myAlumno.Codigo = Convert.ToInt32(codigo);
            myAlumno.Nombre = nombre;
            myAlumno.Correo = correo;
            myAlumno.Nota1 = Convert.ToDouble(nota1);
            myAlumno.Nota2 = Convert.ToDouble(nota2);
            myAlumno.Nota3 = Convert.ToDouble(nota3);
            myAlumno.NotaDef = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2) + Convert.ToDouble(nota3)) / 3;


            if (myAlumno.NotaDef >= 3.5)
            {
                myAlumno.Definitiva = "Aprobado";
            }
            else
            {
                myAlumno.Definitiva = "Reprobado";
            }


            
            
            db.SaveChanges();

        }



        static void Eliminar()
        {
            string cod;
            bool EntradaValidaCodigo = false;
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();
            string ans = "No";
            Console.Clear();
            gui.Marco(1, 119, 1, 5);
            gui.Marco(1, 119, 6, 29);
            gui.BorrarLinea(50, 22, 80);
            Console.SetCursorPosition(2, 2); Console.Write("App Estudiante ");
            Console.SetCursorPosition(2, 4); Console.Write("1. Agregar");
            Console.SetCursorPosition(21, 4); Console.Write("2. Listar");
            Console.SetCursorPosition(42, 4); Console.Write("3. Buscar");
            Console.SetCursorPosition(63, 4); Console.Write("4. Editar");
            Console.SetCursorPosition(84, 4); Console.Write("5. Borrar");
            Console.SetCursorPosition(105, 4); Console.Write("0. Salir");
            Console.SetCursorPosition(75, 2); Console.Write("Escoja Opcion [ ]");
            Console.SetCursorPosition(51, 8); Console.WriteLine("AGREGAR ESTUDIANTE");

            do // pedir el codigo
            {
                gui.BorrarLinea(34, 8, 64);
                Console.SetCursorPosition(8, 10); Console.Write("CODIGO DEL ESTUDIANTE A ELIMINAR [      ]");
                Console.SetCursorPosition(43, 10); cod = Console.ReadLine();
                if (!Vericar.Vacio(cod))
                    if (Vericar.TipoNumero(cod))
                        EntradaValidaCodigo = true;
            } while (!EntradaValidaCodigo);

            int cod2 = Convert.ToInt32(cod);
            var existe = db.Estudiantes.Find(cod2);
            
            var myAlumno = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod2);

            if (existe != null)
            {
                //Estudiantes myAlumno = ObtenerDatos(Convert.ToInt32(cod));
                //int posicion = Posicion(Convert.ToInt32(cod));
                Console.SetCursorPosition(8, 14); Console.Write("CODIGO     :");
                Console.SetCursorPosition(8, 15); Console.Write("NOMBRES     :");
                Console.SetCursorPosition(8, 16); Console.Write("CORREO      :");
                Console.SetCursorPosition(8, 17); Console.Write("NOTA 1      :");
                Console.SetCursorPosition(8, 18); Console.Write("NOTA 2      :");
                Console.SetCursorPosition(8, 19); Console.Write("NOTA 3      :");
                Console.SetCursorPosition(8, 20); Console.Write("NOTA FINAL  :");
                Console.SetCursorPosition(8, 21); Console.Write("CONCEPTO    :");

                Console.SetCursorPosition(22, 14); Console.Write(myAlumno.Codigo);
                Console.SetCursorPosition(22, 15); Console.Write(myAlumno.Nombre);
                Console.SetCursorPosition(22, 16); Console.Write(myAlumno.Correo);
                Console.SetCursorPosition(22, 17); Console.Write("{0:N1}", myAlumno.Nota1);
                Console.SetCursorPosition(22, 18); Console.Write("{0:N1}", myAlumno.Nota2);
                Console.SetCursorPosition(22, 19); Console.Write("{0:N1}", myAlumno.Nota3);
                Console.SetCursorPosition(22, 20); Console.Write("{0:N2}", myAlumno.NotaDef);
                Console.SetCursorPosition(22, 21); Console.Write(myAlumno.Definitiva);

                if (ans == "No")
                {
                    gui.BorrarLinea(40, 22, 80);
                    gui.Marco2(36, 86, 20, 24);
                    Console.SetCursorPosition(38, 22); Console.Write("Seguro desea borra el registro? Escriba si/no: ");
                    ans = Console.ReadLine();

                    if (ans == "Si" || ans == "si")
                    {
                        
                        db.Estudiantes.Remove(myAlumno);
                        db.SaveChanges();
                        gui.BorrarLinea(36, 22, 85);
                        gui.Marco2(36, 86, 20, 24);
                        Console.SetCursorPosition(45, 22); Console.Write("Registro eliminado!");
                        

                    }

                    else if (ans == "No" || ans == "no")
                    {
                        //ListaAlumnos.RemoveAt(posicion);
                        Console.SetCursorPosition(30, 28); Console.Write("Regresará al menu pricipal ");

                    }

                    else
                    {
                        gui.BorrarLinea(37, 22, 85);
                        gui.Marco2(36, 86, 20, 24);
                        Console.SetCursorPosition(45, 22); Console.Write("Respuesta no valida ");
                    }


                }


            }
            else
            {
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 22); Console.Write(" El usuario del codigo " + cod + " No existe");
            }
            Console.SetCursorPosition(29, 29);
            //Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.SetCursorPosition(66, 29);
            Console.ReadLine();




        }






        static bool Existe(int cod)
        {
            bool aux = false;
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();

            foreach (var myAlumno in ListaAlumnosbd)
            {
                if (myAlumno.Codigo == cod)
                    aux = true;
            }
            return aux;
        }

        static int Posicion(int cod)
        {
            int contador = -1;
            int cont = 0;
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();

            foreach (var myAlumno in ListaAlumnosbd)
            {
                contador++;
                if (myAlumno.Codigo == cod)
                    cont = contador;


            }
            return cont;
        }


        static Estudiantes ObtenerDatos(int cod)
        {
            var db = new taller_netContext();
            var ListaAlumnosbd = db.Estudiantes.ToList();
            foreach (var ObjetoAlumno in ListaAlumnosbd)
            {
                if (ObjetoAlumno.Codigo == cod)
                    return ObjetoAlumno;
            }
            return null;

        }

        static void EscrirArchivoXml()
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/Users/Steven/Documents/Sena/2do/POOB/Colegio/Datos/ArchivoAlumnos.xml");
            codificador.Serialize(escribirXml, ListaAlumnos);
            escribirXml.Close();
            Console.Clear();
            gui.Marco(1, 119, 1, 25);
            gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(40, 22); Console.Write(" Archivo guardado con exito... ");
            Console.SetCursorPosition(69, 22);
            Console.ReadLine();
        }

        static void LeerArchivoXml()
        {
            if (File.Exists("C:/Users/Steven/Documents/Sena/2do/POOB/Colegio/Datos/ArchivoAlumnos.xml"))
            {
                ListaAlumnos.Clear();
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("C:/Users/Steven/Documents/Sena/2do/POOB/Colegio/Datos/ArchivoAlumnos.xml");
                ListaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
                Console.Clear();
                gui.Marco(1, 119, 1, 25);
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 22); Console.Write(" Archivo cargado con exito... ");
                Console.SetCursorPosition(69, 22);
                Console.ReadLine();
            }

            else
            {
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 22); Console.Write("Error, valide por favor ubicáción del archivo ");
            }
        }

    }
}
