using System.Reflection;
using System.Text.Json;

namespace _2A6_Winforms_2024
{
    internal static class Program
    {
        private const string JsonFile = "remi_labelle.json";
        private static Compteur modèle = new Compteur();
        [STAThread]
        static void Main()
        {
            if (File.Exists(JsonFile))
            {
                modèle = JsonSerializer.Deserialize<Compteur>(File.ReadAllText(JsonFile));
            }
            Application.ApplicationExit += Application_ApplicationExit;
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(modèle));
        }

        private static void Application_ApplicationExit(object? sender, EventArgs e)
        {
            File.WriteAllText(JsonFile, JsonSerializer.Serialize(modèle));
        }
    }
}