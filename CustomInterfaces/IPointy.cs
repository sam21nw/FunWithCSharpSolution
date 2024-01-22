namespace CustomInterfaces
{
    internal interface IPointy
    {
        byte GetNumberOFPoints();

        string? PropName { get; set; }
        byte Points { get; }
    }
}