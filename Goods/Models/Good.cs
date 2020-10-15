using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Goods.Models
{
    public class Good
    {
        public int GoodId
        {
            get;set;
        }
        public string Desciption
        {
            get;set;
        }

        public int Quantity
        {
            get;
            set;
        }

        //order number can be alphanumeric
        public string OrderNumber
        {
            get;
            set;
        }

        public DateTime DateReceived
        {
            get;
            set;
        } = DateTime.Now;

    }
}
