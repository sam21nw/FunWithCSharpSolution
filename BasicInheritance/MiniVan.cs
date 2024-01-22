namespace BasicInheritance
{
    internal record MiniVan : Car
    {
        public override string ToString()
        {
            return base.ToString() + " Hello";
        }
    }
}