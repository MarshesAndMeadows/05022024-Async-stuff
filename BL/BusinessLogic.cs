using MDL;
using DA;
namespace BL
{
    public class BusinessLogic
    {
        DataAccess da = new DataAccess();

/*
         public bool Create(string newName, string newDesc, double newStockprice, double newProfit)
        {
            Fruit fruit = new Fruit(newName, newDesc, newStockprice, newProfit);

            if (ValidateModel(fruit))
            {
                return db.Create(fruit);
            }
            else
            {
                return false;
            }
        }
        public bool Create(int newId, string newName, string newDesc, double newStockprice, double newProfit)
        {
            Fruit fruit = new Fruit(newId, newName, newDesc, newStockprice, newProfit);

            if (ValidateModel(fruit))
            {
                return db.Create(fruit);
            }
            else
            {
                return false;
            }
        }

        public List<Fruit> Get()
        {
            return db.Get();
        }
        public Fruit Get(int fruitToGet)
        {
            return db.Get(fruitToGet);
        }

        public bool Delete(int fruitToDelete)
        {
            return db.Delete(fruitToDelete);
        }

        public bool Update(int fruitToUpdate, string newName, string newDesc, double newStockprice, double newProfit)
        {
            return db.Update(fruitToUpdate, newName, newDesc, newStockprice, newProfit);
        }
*/




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