using System;
using System.Collections.Generic;

namespace Testlet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // First create a test set - to run/test this
            // per TDD - This should ideally be part of a unit test 
            // However, since this was written in Visual Studio Code - a free version of developer tools - I am not entirely sure how to setup a test stack in here, so a console app will do.
            Testlet tl = new Testlet("First Test", new List<Item>(){
                new Item() {ItemId = "PreTest Item 1", ItemType = ItemTypeEnum.Pretest},
                new Item() {ItemId = "PreTest Item 2", ItemType = ItemTypeEnum.Pretest},
                new Item() {ItemId = "PreTest Item 3", ItemType = ItemTypeEnum.Pretest},
                new Item() {ItemId = "PreTest Item 4", ItemType = ItemTypeEnum.Pretest},

                new Item() {ItemId = "Operational Item 1", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 2", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 3", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 4", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 5", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 6", ItemType = ItemTypeEnum.Operational}
            } );

            var randomizedlist = tl.Randomize();

            foreach(var item in randomizedlist)
            {
                Console.WriteLine($"ItemId = {item.ItemId} ; ItemType = {item.ItemType}");
            }

        }
    }
}
