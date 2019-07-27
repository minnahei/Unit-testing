using System;
namespace TestUnitarios
{
    public class ConsolaController
    {
        public string Salute()
        {
            return "Hola mundo";
        }

        public string SaluteTo(string name)
        {
            if(name is null)
            {
                throw new NullReferenceException("Nombre NULO!!!");
            }
            if(name == "")
            {
                return "Dime quien eres";
            }
            return $"Hola {name}"; //"Hola "+name
        }
    }
}
