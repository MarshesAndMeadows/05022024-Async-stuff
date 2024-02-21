using MDL;
using DA;
namespace BL
{
    public class BusinessLogic
    {
        DataAccess da = new DataAccess();

        public async void AddToList(string name, int age)
        {
            
            Person newGuy = new Person(0,name, age);
            da.AddToListAsync(newGuy);
        }

        public void RemoveFromList(int id)
        {
            da.RemoveFromListAsync(id);
        }

        public async Task<Person> GetModel(int id)
        {
                return await da.GetAsync(id);
        }

        public async Task<Person> Update(int targetID, string newName, int newAge)
        {
            return await da.UpdateAsync(targetID, newName, newAge);
        }
    }
}