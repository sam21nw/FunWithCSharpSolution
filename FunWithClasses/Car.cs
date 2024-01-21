namespace FunWithClasses
{
    internal class Car
    {
        public string? PetName;
        public int CurrSpeed { get; set; }
        public bool InDanger = false;

        public Car(string petName = "Porsche", int currSpeed = 80)
        {
            PetName = petName;
            CurrSpeed = currSpeed;
            if (currSpeed > 100)
            {
                InDanger = true;
            }
        }

        public Car(string petName)
        {
            PetName = petName;
        }

        public override string ToString()
        {
            return $"Car Name:{PetName}, Current Speed:{CurrSpeed}, In Danger:{InDanger}";
        }
    }
}