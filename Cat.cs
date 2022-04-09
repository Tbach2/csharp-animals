namespace csharp_animals
{
    public class Cat : Pet, ITalkable
    {
        private int mousesKilled;

        public Cat(int mousesKilled, string name) : base(name)
        {
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return mousesKilled;
        }

        public void addMouse()
        {
            mousesKilled++;
        }

        public string talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}