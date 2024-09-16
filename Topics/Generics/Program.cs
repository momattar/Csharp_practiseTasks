namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ppl = new List<Person>();
            ppl.Add(new Person {fname = "ff",lname="sd" });
            ppl.Insert(0,new Person { fname = "cc", lname = "xx" });
            foreach (var item in ppl)
            {
                Console.WriteLine(item.fname);
            }
            Console.WriteLine(ppl.Count);
        }
    }
    class Person
    {
        public string fname;
        public string lname;

    }
}
