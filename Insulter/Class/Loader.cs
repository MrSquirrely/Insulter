using System;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;

namespace Insulter.Class {
    public static class Loader {

        private static Assembly assembly = Assembly.GetExecutingAssembly();
        
        private static Insult insult;
        private static Random random = new Random();

        public static void Load() {
            Stream stream = assembly.GetManifestResourceStream("Insulter.insults.json");
            Console.WriteLine(assembly.GetManifestResourceNames());
            StreamReader reader = new StreamReader(stream);
            JsonSerializer serializer = new JsonSerializer();
            insult = (Insult)serializer.Deserialize(reader, typeof(Insult));
            reader.Close();
        }

        public static string GetInsult => insult.insults[random.Next(insult.insults.Length)];
    }
}
