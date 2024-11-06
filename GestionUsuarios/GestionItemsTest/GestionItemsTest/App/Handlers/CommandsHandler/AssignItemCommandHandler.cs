using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionItemsTest.App.Commands;
using GestionItemsTest.Data;
using MediatR;

namespace GestionItemsTest.App.Queries
{
    public class AssignItemCommandHandler : IRequestHandler<AssignItemCommand, bool>
    {
        private readonly IItemRepository _repository;

        public AssignItemCommandHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(AssignItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetItemByIdAsync(request.ItemId);
            if (item == null || item.IsCompleted)
            {
                return false;
            }

            item.AssignedTo = request.AssignedTo;
            await _repository.SaveChangesAsync();
            return true;
        }
    }
}