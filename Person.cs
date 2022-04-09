namespace csharp_animals
{
    public abstract class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}