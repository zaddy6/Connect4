using System;
using System.Collections.Generic;

namespace MenuSystem
{
    public class Menu
    {
        private int _menulevel;
        private const string MenuCommandExit = "X";
        private const string ReturnToPrevious = "P";
        private const string ReturnToMain = "M";
        
        private Dictionary<string, MenuItem> _menuItemsDictionary = new Dictionary<string, MenuItem>();
        
        

        public Menu(int menulevel = 0)
        {
            _menulevel = menulevel;
        }
        
        public string Title { get; set; }
        

        public Dictionary<string, MenuItem> MenuItemsDictionary
        {
            get => _menuItemsDictionary;
            set
            {
                _menuItemsDictionary = value;
               
                    if (_menulevel >= 2)
                    {
                        _menuItemsDictionary.Add(ReturnToPrevious, new MenuItem(){Title = "Return to Previous Menu"}); 
                    }

                    if (_menulevel >= 1)
                    {
                        _menuItemsDictionary.Add(ReturnToMain, new MenuItem(){Title = "Return to Main Menu", CommandToExecute = Run});
                    }
                    _menuItemsDictionary.Add(MenuCommandExit, new MenuItem(){Title = "Exit"});
                
            } 

        }




        public string Run()
        {
            var command = "";
            do
            { 
                
                Console.WriteLine(Title);
                Console.WriteLine("========================");
            
                foreach (var item in MenuItemsDictionary)
                { 
                    Console.Write(item.Key); 
                    Console.Write(" "); 
                    Console.WriteLine(item.Value);
                    
                }
                Console.WriteLine("----------");
                Console.Write(">");

                command = Console.ReadLine().Trim().ToUpper();
                var rCommand = "";

                if (MenuItemsDictionary.ContainsKey(command))
                {
                    var mItem = MenuItemsDictionary[command];
                    if (mItem.CommandToExecute != null)
                    { 
                       rCommand = mItem.CommandToExecute();
                        break;
                        
                    }

                }
                
                if (rCommand == MenuCommandExit)
                {
                    command = MenuCommandExit;
                }

                if (rCommand == ReturnToMain)
                {
                    if (_menulevel != 0)
                    {
                        command = ReturnToMain;
                    }
                }
                
//                if (rCommand == MenuCommandExit)
//                {
//                    command = MenuCommandExit;
//                }
//
//                if (command == ReturnToMain)
//                {
//                    _menulevel = 0;
//                }
//                else
//                {
//                    throw new ArgumentException ("Invalid Command");
//                }
            } while (command != MenuCommandExit &&
                     command != ReturnToMain &&
                     command != ReturnToPrevious);

            return command;
        }


    }
}