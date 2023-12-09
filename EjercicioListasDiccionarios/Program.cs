// See https://aka.ms/new-console-template for more information


namespace EjercicioListasDiccionarios
{
    class Program
    {
        static void Main()
        {
            // Creamos la lista de los  10 productos:

            List<string> productos = new List<string>
            { 
              "Producto1", 
              "Producto2", 
              "Producto3", 
              "Producto4", 
              "Producto5", 
              "Producto6", 
              "Producto7", 
              "Producto8", 
              "Producto9", 
              "Producto10" 
            
            };

            // Usamos  la propiedad Insert y en el índice 3 para agregar un nuevo producto
            productos.Insert(3, "ProductoNuevo");

            
            // Remover el último elemento de la lista
            productos.RemoveAt(productos.Count - 1);

           
            
            // Mostrar la lista en la consola
            Console.WriteLine("Lista de Productos:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto);
            }

            // Creamos un diccionario con los datos de los departamentos
            Dictionary<string, string> departamento1 = new Dictionary<string, string>()
        {
            {"nombre", "Frnacisco Morazán"},
            {"cabecera", "Tegucigalpa"},
            {"superficie", "8,470 km2"},
            {"población", "Alrededor de 1.7 millones de habitantes"}
        };

            Dictionary<string, string> departamento2 = new Dictionary<string, string>()
        {
            {"nombre", "Cortes"},
            {"cabecera", "San Pedro Sula"},
            {"superficie", "3,954 km2"},
            {"población", "809,000 habitantes"}
        };

            // Agregamos los 2 departamentos a la lista de departamentos
            List<Dictionary<string, string>> departamentos = new List<Dictionary<string, string>>() 
            { departamento1, departamento2 };

            
            
            // Mostrar en la consola el diccionario con su respectiva llave y valor
            Console.WriteLine("\nDatos de los Departamentos:");

            foreach (var departamento in departamentos)
            {
                foreach (var dato in departamento)
                {
                    Console.WriteLine(dato.Key + ": " + dato.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
