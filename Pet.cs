namespace csharp_animals
{
    public abstract class Pet
    {
        public string name;
        public Pet(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}