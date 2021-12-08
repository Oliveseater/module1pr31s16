using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace block1
{
    public class DopClass : MainClass
    {
        public double CountWorksProg;

        public DopClass(string Lastname, double CountProg, double Language, double CountWorksProg) : base(Lastname, CountProg, Language)
        {
            this.CountWorksProg = CountWorksProg;
        }
        public override double Q_answer(double CountWorksProg, double CountProg)
        {
            return (CountProg * Language) * CountWorksProg / CountProg;
        }
    }
}
