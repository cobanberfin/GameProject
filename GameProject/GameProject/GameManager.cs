using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    
     public    class GameManager : IGameServices
        {
            public void Add(Game game)
            {
                Console.WriteLine(game.GameName + "Eklendi.");
            }

            public void Delete(Game game)
            {
                Console.WriteLine(game.GameName + "Silindi.");
            }

            public void UpDate(Game game)
            {
                Console.WriteLine(game.GameName + "Güncellendi.");
            }
        }
    }


    

