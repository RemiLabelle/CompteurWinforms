using Microsoft.VisualBasic.Devices;
using System.Text.Json;

namespace WinFormsApp1
{
    internal static class Program
    {
        private const string JsonFile = "remi_labelle.json";
        private const string JsonFileConfiguration = "configuration.json";
        private static Compteur mod�le = new Compteur();
        private static Configuration config = new Configuration();

        [STAThread]
        static void Main()
        {
            if (File.Exists(JsonFile)) 
            {
                mod�le = JsonSerializer.Deserialize<Compteur>(File.ReadAllText(JsonFile));
            }

            if (File.Exists(JsonFileConfiguration))
            {
                config = JsonSerializer.Deserialize<Configuration>(File.ReadAllText(JsonFileConfiguration));
            }
            Application.ApplicationExit += Application_ApplicationExit;
            ApplicationConfiguration.Initialize();
            Application.Run(new RemiLabelle(mod�le, config));
        }

        private static void Application_ApplicationExit(object? sender, EventArgs e) 
        {
            File.WriteAllText(JsonFile, JsonSerializer.Serialize(mod�le));
            File.WriteAllText(JsonFileConfiguration, JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}