using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
  public  interface IGameServices
    {

        void Add(Game game);
        void UpDate(Game game);
        void Delete(Game game);
    }
}
