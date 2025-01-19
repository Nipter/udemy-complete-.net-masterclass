namespace _36_DependencyInjection
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }

    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }

    }

    public class Builder : IToolUser
    {
        // Inject dependencies via Setters
        //public Hammer Hammer { private get; set; }
        //public Saw Saw { private get; set; }

        private Hammer _hammer;
        private Saw _saw;

        // Constructor Dependency Injection (DI)
        //public Builder(Hammer hammer, Saw saw)
        //{
        //    _hammer = hammer;
        //    _saw = saw;
        //}

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            // Inject dependencies via Setters
            //Hammer.Use();
            //Saw.Use();
            Console.WriteLine("Home built");
        }

        // Inject dependencies via interface
        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor Dependency Injection (DI)
            //Builder builder = new Builder(new Hammer(), new Saw());

            // Inject dependencies via Setters
            //Builder builder = new Builder();
            //builder.Hammer = new Hammer();
            //builder.Saw = new Saw();

            // Inject dependencies via interfaces
            Builder builder = new Builder();
            // Inject dependencies via Setters
            builder.SetHammer(new Hammer());
            builder.SetSaw(new Saw());

            builder.BuildHouse();
        }
    }
}
