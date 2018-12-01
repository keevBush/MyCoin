using System;
using System.Collections.Generic;
using System.Text;

namespace MyCoinServerData.Models
{
    public class Block
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string HashPrecedent { get; set; }
        public List<Transaction> ListTransactions { get; set; }
    }
}
