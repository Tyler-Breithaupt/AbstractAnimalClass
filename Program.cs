namespace AbstractAnimalClass;
abstract class Animal
{
    // Property
    public abstract string Name { get; set; }
    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }
}

class Program
{
    class Dog : Animal
    {
        // override the abstract property
        public override string Name { get; set; }

        public string Breed { get; set; }
        public int Age { get; set; }

        public override string Describe()
        {
            return $"I am a {Breed} dog named {Name}. I am {Age} years old.";
        }

        public Dog()
        {
            Name = "DefaultDog";
            Breed = "Unknown";
            Age = 1;
        }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }
    }
    static void Main(string[] args)
    {
        Dog defaultDog = new Dog();
        Dog parameterizedDog = new Dog("Buddy", "Golden Retriever", 3);

        Console.WriteLine(defaultDog.Describe());
        Console.WriteLine(defaultDog.whatAmI());

        Console.WriteLine(parameterizedDog.Describe());
        Console.WriteLine(parameterizedDog.whatAmI());
    }
}

