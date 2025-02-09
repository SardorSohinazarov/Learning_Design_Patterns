using System;
using System.Text.Json;

public interface IPrototype
{
    object Clone();
    object DeepClone();
}

public class Model3D<T> : IPrototype
{
    public string Name { get; set; }
    public string Texture { get; set; }

    public Model3D(string name, string texture)
    {
        Name = name;
        Texture = texture;
    }

    public object Clone() 
        => this.MemberwiseClone();

    public object DeepClone()
    {
        string json = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<T>(json);
    }
}