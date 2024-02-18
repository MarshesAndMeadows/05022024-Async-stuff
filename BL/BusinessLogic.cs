using MDL;
using DA;
namespace BL
{
    public class BusinessLogic
    {
        DataAccess da = new DataAccess();

        public void AddToList(string name, int age)
        {
            
            Person newGuy = new Person(0,name, age);
            da.AddToList(newGuy);
        }

        public void RemoveFromList(int id)
        {
            da.RemoveFromList(id);
        }

        public Person GetModel(int id)
        {
            return da.Get(id);
        }

        public void Update(int targetID, string newName, int newAge)
        {
            da.Update(targetID, newName, newAge);
        }
    }
}