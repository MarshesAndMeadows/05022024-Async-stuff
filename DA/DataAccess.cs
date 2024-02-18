using MDL;

namespace DA
{
    public class DataAccess
    {
        private List<Person> list = new List<Person>();
        public DataAccess()
        {
            Thread.Sleep(5000);
            list = new List<Person>();
            SeedData();
        }
        public void RemoveFromList(int idToRemove)
        {
            Thread.Sleep(5000);
            Person target = list.Find(o => o.Id == idToRemove);
            list.Remove(target);
        }
        public void AddToList(Person guyToAdd)
        {
            Thread.Sleep(5000);
            guyToAdd.Id = list.Max(o => o.Id + 1);
            list.Add(guyToAdd);
        }
        public Person Get(int id)
        {
            Thread.Sleep(5000);
            Person guyToGet = list.Find(o => o.Id == id);
            return guyToGet;
        }
        public Person Update(int targetID, string newName, int newAge)
        {
            Thread.Sleep(5000);
            Person target = list.Find(o => o.Id == targetID);
            target.Name = newName;
            target.Age = newAge;
            return target;
        }
        void SeedData()
        {
            list.Add(new Person(1, "aarl", 18));
            list.Add(new Person(2, "barl", 18));
            list.Add(new Person(3, "carl", 18));
            list.Add(new Person(4, "darl", 18));
            list.Add(new Person(5, "earl", 18));
            list.Add(new Person(6, "farl", 18));
            list.Add(new Person(7, "garl", 18));
            list.Add(new Person(8, "harl", 18));
            list.Add(new Person(9, "iarl", 18));
            list.Add(new Person(10, "jarl", 18));
        }
    }
}