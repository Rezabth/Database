using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Models
{
   public class Animal
    {
        public int AnimalId{ get; set; }
        public int KeeperId { get; set; }
        public  virtual Keeper Keeper { get; set; }
        public string   Name{ get; set; }
        public string Email { get; set; }
        public string  Race { get; set; }

    }

}
