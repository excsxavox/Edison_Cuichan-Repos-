using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionItemsTest.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Relevance { get; set; } // "Alta" o "Baja"
        public bool IsCompleted { get; set; }
        public string AssignedTo { get; set; }
    }
}