using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace GestionItemsTest.App.Commands
{
       public class AssignItemCommand : IRequest<bool>
    {
        public int ItemId { get; set; }          // Identificador del ítem a asignar
        public string AssignedTo { get; set; }    // Nombre de usuario al que se asignará el ítem

        public AssignItemCommand(int itemId, string assignedTo)
        {
            ItemId = itemId;
            AssignedTo = assignedTo;
        }
    }
}