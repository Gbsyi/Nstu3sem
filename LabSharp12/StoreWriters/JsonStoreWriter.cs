using System.Text.Json;
using LabSharp11.Store;

namespace LabSharp11.StoreWriters;

public class JsonStoreWriter
{
    private readonly string _path;
    private readonly JsonSerializerOptions _options = new()
    {
        IncludeFields = true,
        WriteIndented = true,
    };
    public JsonStoreWriter(string path)
    {
        _path = path;
    }
    
    public void Save(SimulationStore company)
    {
        using var writer = new StreamWriter(_path, new FileStreamOptions
        {
            Access = FileAccess.Write,
            Mode = FileMode.Create,
        });
        
        var json = JsonSerializer.Serialize(company, _options);
        writer.Write(json);
    }
    
    public SimulationStore? Restore()
    {
        using var reader = new StreamReader(_path, new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate
        });
        var json = reader.ReadToEnd();
        return string.IsNullOrEmpty(json) ? null : JsonSerializer.Deserialize<SimulationStore>(json, _options);
    }
}