﻿using System;
using System.Collections.Generic;

namespace Merlin.Networking.Messages.Response
{
    [Serializable]
    public struct GetInventoryItems : IMessage
    {
        public List<InventoryItem> Items;

        public GetInventoryItems(List<InventoryItem> items)
        {
            Items = items;
        }
    }

    [Serializable]
    public struct InventoryItem
    {
        public string Name;
        public int Count;
        public int MaxStack;

        public InventoryItem(string name, int count, int maxStack = 999)
        {
            Name = name;
            Count = count;
            MaxStack = maxStack;
        }
    }
}
