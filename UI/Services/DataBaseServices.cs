using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Services
{
    class DataBaseServices<T>
    {
        public bool IsOpen { get; set; }
        public bool Connect(string connectionString)
        {
            IsOpen = true;
            return true;
        }

        public bool Disconect()
        {
            IsOpen = false;
            return true;
        }

        public bool Create()
        {
            return true;
        }

        public bool Delete(T person)
        {
            return true;
        }
        public bool Delete(IEnumerable<T> persons)
        {
            return true;
        }

        public virtual IEnumerable<T> Read()
        {
            return  new List<T>();
        }

        public bool Update(IEnumerable<T> persons)
        {
            return true;
        }
    }
}
