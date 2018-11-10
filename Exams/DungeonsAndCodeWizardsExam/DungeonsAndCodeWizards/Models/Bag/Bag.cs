using System;
using System.Collections.Generic;
using System.Linq;
using DungeonsAndCodeWizards.Factory;

namespace DungeonsAndCodeWizards.Models.Bag
{
    public abstract class Bag
    {
        private List<Item.Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
        }

        public IReadOnlyCollection<Item.Item> Items { get => items; }

        public long Load
        {
            get { return Items.Sum(x => x.Weight); }
        }

        public int Capacity { get; protected set; } = 100;

        public void AddItem(Item.Item item)
        {
            if (item.Weight + Load > Capacity )
            {
                throw new InvalidOperationException("Bag is full!");
            }

            items.Add(item);
        }

        public Item.Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            ItemFactory factory = new ItemFactory();
            Item.Item item = factory.ItemExist(name);

            return item;
        }
    }
}