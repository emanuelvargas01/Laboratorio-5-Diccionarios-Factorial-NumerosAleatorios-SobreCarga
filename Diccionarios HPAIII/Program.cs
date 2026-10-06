namespace Diccionarios_HPAIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> datosInventario = new Dictionary<string, object>
{
{"Nombre", "Laptop HP"},
{"Precio", 850.99m},
{"Cantidad",15}
};
            var setParts = new List<string>();
            foreach (var key in datosInventario.Keys)
            {
                setParts.Add($"{key} = @{key}");
            }
            string setClause = string.Join(", ", setParts);
            //Imprimimos el resultado en la consola para verificar commo se armo
            //Console.WriteLine($"Tabla destino: {tbName}");
            Console.WriteLine($"Clausula set generada: {setClause}");

            var columns = string.Join(",", datosInventario.Keys);
            var placeholders = "@" + string.Join(", @", datosInventario.Keys);
            string sql = $"INSERT INTO productos ({columns}) VALUES ({placeholders})";
            Console.WriteLine($"la cadena sql es:; {sql} ");
        }
    }
}
