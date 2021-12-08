using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace block1
{
    public class MainClass
    {
        public string LastName;
        public double CountProg;
        public double Language;
        public MainClass(string Lastname, double CountProg, double Language)
        {
            this.LastName = Lastname;
            this.CountProg = CountProg;
            this.Language = Language;
        }
        public virtual double Q_answer(double CountProg, double Language)
        {
            return CountProg * Language;
        }
        
    }
}
