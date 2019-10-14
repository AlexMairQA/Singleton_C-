using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class God
    {
        private static God InstanceOf { get; set; }

        private string GodSays { get; set; }

        private God(string message)
        {
            this.GodSays = message;
            
        }

        public static God GetInstance(string message)
        {
            if (InstanceOf == null)
            {
                InstanceOf = new God(message);
                
                return InstanceOf;
            }
            else return null;
        }
        public string getGodSays()
        {
            return this.GodSays;
        }
    }
}
