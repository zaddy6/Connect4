using System;
using System.Collections.Generic;
using MenuSystem;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu(1)
            {
                Title = "Connect 4",
                MenuItemsDictionary = new Dictionary<string, MenuItem>()
                {
                    {
                        "1", new MenuItem()
                        {
                            Title = "Player Against Computer",
                            CommandToExecute = null
                        }
                    },
                    {
                        "2", new MenuItem()
                        {
                            Title = "Human Against Human",
                            CommandToExecute = null
                        }
                    }
                }

            };

            var menu0 = new Menu()
            {
                Title = "Play Connect 4",
                MenuItemsDictionary = new Dictionary<string, MenuItem>()
                {
                    {
                        "S", new MenuItem()
                        {
                            Title = "Start Game",
                            CommandToExecute = menu.Run
                        }
                    }
                    
                    
                }
            };

            menu0.Run();



        }
    }
}