namespace FunWithClasses
{
    internal class Car
    {
        public string PetName = "Porsche";
        public int CurrSpeed = 120;

        public Car()
        {
        }

        public Car(string petName, int currSpeed, out bool inDanger)
        {
            PetName = petName;
            CurrSpeed = currSpeed;
            if (currSpeed > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        public Car(string petName)
        {
            PetName = petName;
        }

        public override string ToString()
        {
            return $"Car Name:{PetName}, Current Speed:{CurrSpeed}";
        }
    }
}