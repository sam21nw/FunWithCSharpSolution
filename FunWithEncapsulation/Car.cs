class Car
{
    public string? PetName { get; set; }
    public int Speed { get; set; }
    public string? Color { get; set; }

    public override string ToString()
    {
        return $"Car Name:{PetName}, Speed:{Speed}, Color:{Color}";
    }
}