using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WASM_PizzaPlace.Shared
{
    public static class ExtensionesDeDebug
    {
        private static JsonSerializerOptions opciones = new
       JsonSerializerOptions
        { WriteIndented = true };
        public static string ToJson(this object obj)
        => JsonSerializer.Serialize(obj, opciones);
    }
}
