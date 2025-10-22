using System.Collections.Generic;
using System.ComponentModel;

namespace DemoLib
{
    public class Order
    {
        private BindingList<OrderRecord> records_ = new BindingList<OrderRecord>();

        public void AddRecord(OrderRecord record)
        {
            records_.Add(record);
        }

        public BindingList<OrderRecord> GetRecords()
        {
            return records_;
        }
    }
}
