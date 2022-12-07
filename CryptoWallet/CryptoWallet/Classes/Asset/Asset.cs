using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Asset
{
    public abstract class Asset
    {
        public Guid Address { get; }
        public string Name { get; set; } //unique     
        public Asset(string name)
        {
            Address = Guid.NewGuid();
            Name = name;
        }
    }
}
