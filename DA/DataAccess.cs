using MDL;

namespace DA
{
    public class DataAccess
    {
        public DataAccess() 
        {
            List<Model> list = new List<Model>();
            SeedData(list);
        }
        List<Model> SeedData(List<Model> list)
        {
            list.Add(new Model(1,"arl", 18));
            list.Add(new Model(2, "barl", 18));
            list.Add(new Model(3, "carl", 18));
            list.Add(new Model(4, "darl", 18));
            list.Add(new Model(5, "earl", 18));
            list.Add(new Model(6, "farl", 18));
            list.Add(new Model(7, "garl", 18));
            list.Add(new Model(8, "harl", 18));
            list.Add(new Model(9, "iarl", 18));
            list.Add(new Model(10, "jarl", 18));
            return list;
        }

        public void RemoveFromList(int idToRemove, List<Model> targetList)
        {
            Model target = targetList.Find(o=>o.Id == idToRemove);
            targetList.Remove(target);
        }
        public void AddToList(Model guyToAdd, List<Model> targetList)
        {
            targetList.Add(guyToAdd);
        }

        public Model Get(int id, List<Model> targetList)
        {
            Model guyToGet = targetList.Find(o=> o.Id == id);
            return guyToGet;
        }

        public Model Update (int targetID, string newName, int newAge, List<Model> targetList)
        {
            Model target = targetList.Find(o => o.Id == targetID);
            target.Name = newName;
            target.Age = newAge;
            return target;
        }
    }
}