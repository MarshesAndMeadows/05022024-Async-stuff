using MDL;
using System.Reflection.Metadata.Ecma335;

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


        public async void RemoveFromListAsync(int idToRemove)
        {
            Thread.Sleep(5000);
            await Task.Factory.StartNew(() => RemoveMethod(idToRemove));
        }
        public async void AddToListAsync(Person guyToAdd)
        {
            Thread.Sleep(5000);
            await Task.Factory.StartNew(() => AddMethod(guyToAdd));
        }
        public async Task<Person> GetAsync(int id)
        {
            Thread.Sleep(5000);
            return await Task<Person>.Factory.StartNew(() => GetMethod(id));
        }
        public async Task<Person> UpdateAsync(int targetID, string newName, int newAge)
        {
            Thread.Sleep(5000);
            return await Task<Person>.Factory.StartNew(() => UpdateMethod(targetID,newName,newAge));
        }

        private void RemoveMethod(int id)
        {
            Person target = list.Find(o => o.Id == id);
            list.Remove(target);
        }
        private void AddMethod(Person person)
        {
            person.Id = list.Max(o => o.Id + 1);
            list.Add(person);
        }
        private Person GetMethod(int id)
        {
            Person guyToGet = list.Find(o => o.Id == id);
            return guyToGet;
        }
        private Person UpdateMethod(int targetID, string newName, int newAge)
        {
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