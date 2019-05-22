﻿using System;
using System.IO;
using System.Reflection;

namespace hennythingIsPossible
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller obj = new Controller();        

            HennyArt.DisplayHennyArt();

            switch (Menu.DisplayMainMenu())
            {
                case MenuEnum.DisplayInventory:
                    var entireMenuList = new MenuView(obj.Menu);
                    entireMenuList.DisplayLiquorMenu();                
                    break;
                case MenuEnum.AddProductToOrder:
                    var filteredList = obj.FilterListByCategory(obj.Menu, "Rum");
                    obj.PickLiquorFromFilteredList(filteredList);
                    obj.AddAlcoholToOrder(obj.CurrentLiquorPick);
                    break;
                case MenuEnum.LiquorInfoCenter:
                    InfoCenter inf = new InfoCenter("", "");
                    inf.Alcohol();
                    break;
                case MenuEnum.CashOut:
                    break;
                default:
                    break;
            }
       
            Console.ReadLine();


        }
    }
}

