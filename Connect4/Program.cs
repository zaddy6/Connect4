using System;
using System.Collections.Generic;
using GameEngine;
using MenuSystem;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {

            var game = new Game(4,4);
            
            
            
            
            var menu2 = new Menu(2)
            {
              Title = "Select Board Size",
              MenuItemsDictionary = new Dictionary<string, MenuItem>()
              {
                  {
                      "1", new MenuItem()
                      {
                          Title = "Small Board",
                          CommandToExecute = null
                      }
                  },
                  {
                      "2", new MenuItem()
                      {
                          Title = "Medium Board",
                          CommandToExecute = null
                      }
                  },
                  {
                      "3", new MenuItem()
                      {
                          Title = "Large Board",
                          CommandToExecute = null
                      }
                  },
                  {
                      "4", new MenuItem()
                      {
                          Title = "Custom Board",
                          CommandToExecute = null
                      }
                  }
              }
            };
            var menu = new Menu(1)
            {
                Title = "Play Connect 4",
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
                            CommandToExecute = menu2.Run
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