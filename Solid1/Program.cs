using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList = new List<Item>();

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void DeleteItem(Item item)
        {
            itemList.Remove(item);
        }

        public int GetItemCount()
        {
            return itemList.Count;
        }

        public List<Item> GetItems()
        {
            return itemList;
        }

        public decimal CalculateTotalSum()
        {
            // Логіка підрахунку загальної суми
            return 0; // Заглушка
        }
    }

    class OrderRepository
    {
        public void Load(Order order)
        {
            // Логіка завантаження замовлення
        }

        public void Save(Order order)
        {
            // Логіка збереження замовлення
        }

        public void Update(Order order)
        {
            // Логіка оновлення замовлення
        }

        public void Delete(Order order)
        {
            // Логіка видалення замовлення
        }
    }

    class OrderPrinter
    {
        public void PrintOrder(Order order)
        {
            // Логіка друку замовлення
        }

        public void ShowOrder(Order order)
        {
            // Логіка відображення замовлення на екрані
        }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
