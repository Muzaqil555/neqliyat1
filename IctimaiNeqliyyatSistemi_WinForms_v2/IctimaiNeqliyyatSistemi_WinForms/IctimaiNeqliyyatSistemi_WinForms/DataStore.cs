using System;
using System.IO;
using System.Text.Json;

namespace IctimaiNeqliyyatSistemi_WinForms
{
    public static class DataStore
    {
        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true
        };

        public static string DataPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "transport_data.json");

        public static TransportState Load()
        {
            try
            {
                if (!File.Exists(DataPath))
                    return new TransportState();

                var json = File.ReadAllText(DataPath);
                var state = JsonSerializer.Deserialize<TransportState>(json, Options);
                return state ?? new TransportState();
            }
            catch
            {
                return new TransportState();
            }
        }

        public static void Save(TransportState state)
        {
            var json = JsonSerializer.Serialize(state, Options);
            File.WriteAllText(DataPath, json);
        }
    }
}
