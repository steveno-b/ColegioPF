using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ColegioPF
{
    class Validaciones
    {
        public bool Vacio(string texto)
        {
            if (texto.Equals(""))
            {
                gui.BorrarLinea(40, 22, 80);
                gui.Marco2(36, 86, 20, 24);
                Console.SetCursorPosition(45, 22); Console.Write("El texto no puede ser vacio");
                Console.ReadLine();
                //Console.SetCursorPosition(40, 22); Console.Write(" El texto no puede ser vacio");
                return true;
            }
            else
                return false;

        }

        public bool TipoNumero(string texto)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                gui.BorrarLinea(40, 22, 80);
                gui.Marco2(36, 86, 20, 24);
                Console.SetCursorPosition(45, 22); Console.Write("La Entrada debe ser numerica");
                Console.ReadLine();
                //Console.SetCursorPosition(40, 22); Console.Write(" La Entrada debe ser numerica");
                return false;
            }
        }


        public bool TipoTexto(string texto)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                gui.BorrarLinea(40, 22, 80);
                gui.Marco2(36, 90, 20, 24);
                Console.SetCursorPosition(38, 22); Console.Write("La Entrada debe ser texto sin caracteres especiales!");
                Console.ReadLine();
                //Console.SetCursorPosition(40, 22); Console.Write(" La Entrada debe ser texto ");
                return false;
            }
        }

        public bool TipoCorreo(string texto)
        {
            Regex regla = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                gui.BorrarLinea(40, 22, 80);
                gui.Marco2(36, 86, 20, 24);
                Console.SetCursorPosition(45, 22); Console.Write("La Entrada debe ser tipo correo");
                Console.ReadLine();
                //Console.SetCursorPosition(40, 22); Console.Write(" La Entrada debe ser texto ");
                return false;
            }
        }

        public bool sino(string texto)
        {
            if (texto == "s" || texto == "S" || texto == "N" || texto == "n")
                return true;
            else
            {
                gui.Marco2(36, 86, 20, 24);
                Console.SetCursorPosition(45, 22); Console.Write("La Entrada debe ser S o N");
                Console.ReadLine();
                //Console.SetCursorPosition(40, 22); Console.Write(" La Entrada debe ser S o N  ");
                return false;
            }
        }
    }
}
