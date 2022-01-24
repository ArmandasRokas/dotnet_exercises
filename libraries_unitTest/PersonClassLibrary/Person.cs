namespace PersonClassLibrary
{
    public class Person
    {
        public string Name { get; set; } 

        public  Person(string name)
        {
            if(name.Length < 3)
            {
                throw new ArgumentException("Name should be at least three characters.");
            }
            Name = name;
        }

        public void printName()
        {
            Console.WriteLine(Name);
        }

        public void Deconstruct(out string fname)
        {
            fname = Name;
        }


    }
}