using MDL;
using DA;
namespace BL
{
    public class BusinessLogic
    {
        DataAccess da = new DataAccess();
       0 void AddToList(string name, int age, List<Model> targetList)
        {
            int id = targetList.Max(o => o.Id) + 1;
            Model newGuy = new Model(id, name, age);
            da.AddToList(newGuy, targetList);
        }

        void RemoveFromList(int id,  List<Model> targetList)
        {
            da.RemoveFromList(id, targetList);
        }

        Model GetModel(int id, List<Model>targetList)
        {
            return da.Get(id, targetList);
        }

        void Update(int targetID, string newName, int newAge, List<Model> targetList)
        {
            da.Update(targetID, newName, newAge, targetList);
        }
    }
}