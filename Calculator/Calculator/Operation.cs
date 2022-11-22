using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operation
    {
        //left side ot the op
        public string leftside {get; set;}
        //right side of the op
        public string rightside { get; set; }
        public operationType operationType { get; set;}
        //this operation is initially done 
        public Operation inneroperation { get; set;}

        //constructor
        public Operation()
        {
            this.leftside = string.Empty;
            this.rightside = string.Empty;
        }
    }
}
