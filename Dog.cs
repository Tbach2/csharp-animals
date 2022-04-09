namespace csharp_animals
{
    public class Dog : Pet, ITalkable
    {

        private bool friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            this.friendly = friendly;
        }


        public bool isFriendly()
        {
            return friendly;
        }

        public string talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}