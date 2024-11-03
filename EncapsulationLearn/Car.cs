namespace EncapsulationLearn;

internal record Car
{
    private string _name;
    private int _currSpeed;
    private bool _inDanger;

    public Car(string name, int currSpeed, out bool inDanger)
    {
        _name = name;
        _currSpeed = currSpeed;
        if (currSpeed > 100)
            inDanger = true;
        else
            inDanger = false;
        this._inDanger = inDanger;
    }
}
