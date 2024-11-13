global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Xml;
global using System.Xml.Serialization;

static void SaveAsXmlFormat<T>(T objGraph, string fileName)
{
    //Must declare type in the constructor of the XmlSerializer
    XmlSerializer xmlFormat = new(typeof(T));
    using Stream fStream = new FileStream(fileName,
    FileMode.Create, FileAccess.Write, FileShare.None);
    xmlFormat.Serialize(fStream, objGraph);
}

Console.WriteLine("***** Fun with Object Serialization *****\n");

Car car = new("dude", 32, true);

SaveAsXmlFormat(car, "CarData.xml");
Console.WriteLine("=> Saved car in XML format!");

public class Car
{
    public string? Name { get; set; }
    public int Age { get; set; }
    [XmlAttribute]
    public Radio radio = new();
    public Car()
    {

    }
    public Car(string name, int age, bool playing)
    {
        Name = name;
        Age = age;
        radio.Playing = playing;
    }
}
public class Radio
{
    public bool Playing { get; set; }
}