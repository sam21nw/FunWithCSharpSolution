namespace FunWithLinq
{
    public static class ObjectExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here:\n\t->{obj.GetType()}");
        }
        public static void GetFastCars(this IEnumerable<Car> cars)
        {
            var fastCars = from c in cars
                           where c.Speed > 55
                           select c;

            foreach (var car in fastCars)
            {
                int i = 1;
                Console.WriteLine($"Fast car {i}: {car.PetName}");
                i++;
            }
        }
    }
}
