using System;
using System.Collections.Generic;
using System.Linq;

namespace AppCitas
{
    // ===== Modelo =====
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int DuracionMinutos { get; set; }
        public bool Disponible { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-3} {1,-22} {2,-14} {3,10:N0} {4,6} min  {5}",
                Id, Nombre, Categoria, Precio, DuracionMinutos,
                Disponible ? "Disponible" : "No disponible");
        }
    }

    // ===== Catálogo (lógica de consulta) =====
    public class CatalogoServicios
    {
        private readonly List<Servicio> servicios = new List<Servicio>();
        private int siguienteId = 1;

        public Servicio Agregar(string nombre, string descripcion, string categoria,
                                decimal precio, int duracionMinutos, bool disponible)
        {
            var servicio = new Servicio
            {
                Id = siguienteId++,
                Nombre = nombre,
                Descripcion = descripcion,
                Categoria = categoria,
                Precio = precio,
                DuracionMinutos = duracionMinutos,
                Disponible = disponible
            };
            servicios.Add(servicio);
            return servicio;
        }

        public List<Servicio> ObtenerTodos()
        {
            return servicios.ToList();
        }

        public List<Servicio> ObtenerDisponibles()
        {
            return servicios.Where(s => s.Disponible).ToList();
        }

        public Servicio BuscarPorId(int id)
        {
            return servicios.FirstOrDefault(s => s.Id == id);
        }

        public List<Servicio> BuscarPorNombre(string texto)
        {
            return servicios
                .Where(s => s.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Servicio> FiltrarPorCategoria(string categoria)
        {
            return servicios
                .Where(s => s.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<string> ObtenerCategorias()
        {
            return servicios.Select(s => s.Categoria).Distinct().OrderBy(c => c).ToList();
        }
    }

    // ===== Interfaz de consola =====
    class Program
    {
        static CatalogoServicios catalogo = new CatalogoServicios();

        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== SERVICIOS DISPONIBLES ===");
                Console.WriteLine("1. Ver todos los servicios");
                Console.WriteLine("2. Ver solo servicios disponibles");
                Console.WriteLine("3. Buscar por nombre");
                Console.WriteLine("4. Filtrar por categoría");
                Console.WriteLine("5. Ver detalle de un servicio");
                Console.WriteLine("6. Agregar un servicio");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                    opcion = -1;

                switch (opcion)
                {
                    case 1: Mostrar(catalogo.ObtenerTodos()); break;
                    case 2: Mostrar(catalogo.ObtenerDisponibles()); break;
                    case 3: BuscarNombre(); break;
                    case 4: FiltrarCategoria(); break;
                    case 5: VerDetalle(); break;
                    case 6: AgregarServicio(); break;
                    case 0: Console.WriteLine("Saliendo..."); break;
                    default: Console.WriteLine("Opción inválida."); break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 0);
        }

        static void Mostrar(List<Servicio> lista)
        {
            Console.WriteLine();
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay servicios para mostrar.");
                return;
            }
            Console.WriteLine("{0,-3} {1,-22} {2,-14} {3,10} {4,10}  {5}", "ID", "Servicio", "Categoría", "Precio", "Duración", "Estado");
            Console.WriteLine(new string('-', 80));
            foreach (var s in lista)
                Console.WriteLine(s);
        }

        static void BuscarNombre()
        {
            Console.Write("Nombre a buscar: ");
            Mostrar(catalogo.BuscarPorNombre(Console.ReadLine()));
        }

        static void FiltrarCategoria()
        {
            var categorias = catalogo.ObtenerCategorias();
            if (categorias.Count == 0)
            {
                Console.WriteLine("Todavía no hay categorías registradas.");
                return;
            }
            Console.WriteLine("Categorías: " + string.Join(", ", categorias));
            Console.Write("Categoría: ");
            Mostrar(catalogo.FiltrarPorCategoria(Console.ReadLine()));
        }

        static void VerDetalle()
        {
            Console.Write("ID del servicio: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            Servicio s = catalogo.BuscarPorId(id);
            if (s == null)
            {
                Console.WriteLine("Servicio no encontrado.");
                return;
            }

            Console.WriteLine("\nNombre:      " + s.Nombre);
            Console.WriteLine("Descripción: " + s.Descripcion);
            Console.WriteLine("Categoría:   " + s.Categoria);
            Console.WriteLine("Precio:      " + s.Precio.ToString("N0"));
            Console.WriteLine("Duración:    " + s.DuracionMinutos + " minutos");
            Console.WriteLine("Estado:      " + (s.Disponible ? "Disponible" : "No disponible"));
        }

        static void AgregarServicio()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Categoría: ");
            string categoria = Console.ReadLine();

            decimal precio;
            Console.Write("Precio: ");
            if (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
            {
                Console.WriteLine("Precio inválido.");
                return;
            }

            int duracion;
            Console.Write("Duración (minutos): ");
            if (!int.TryParse(Console.ReadLine(), out duracion) || duracion <= 0)
            {
                Console.WriteLine("Duración inválida.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre es obligatorio.");
                return;
            }

            catalogo.Agregar(nombre, descripcion, categoria, precio, duracion, true);
            Console.WriteLine("Servicio agregado.");
        }
    }
}