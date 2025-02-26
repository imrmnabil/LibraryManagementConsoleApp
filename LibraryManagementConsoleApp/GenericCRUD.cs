using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleApp
{
    class GenericCRUD<T>
    {
        private readonly List<T> items = [];
        public void Add(T item)
        {
            if (items != null && !items.Any(u => u.Equals(item)))
            {
                items.Add(item);
                Console.WriteLine("{0} added successfully.", item?.GetType().Name);
            }
            else
            {
                Console.WriteLine("{0} with the same ID already exists.", item?.GetType().Name);
            }
        }

        public void Remove(T item)
        {
            if (items != null && items.Any(u => u.Equals(item)))
            {
                items.Remove(item);
                Console.WriteLine("{0} removed successfully.", item?.GetType().Name);
            }
            else
            {
                Console.WriteLine("{0} not found.", item?.GetType().Name);
            }
        }

        public void Update(T item, T newItem)
        {
            if (items != null && items.Any(u => u.Equals(item)))
            {
                int index = items.IndexOf(item);
                items[index] = newItem;
                Console.WriteLine("{0} updated successfully.", item?.GetType().Name);
            }
            else
            {
                Console.WriteLine("{0} not found.", item?.GetType().Name);
            }
        }

        public List<T> GetAll()
        {
            return items;
        }
    }
}
