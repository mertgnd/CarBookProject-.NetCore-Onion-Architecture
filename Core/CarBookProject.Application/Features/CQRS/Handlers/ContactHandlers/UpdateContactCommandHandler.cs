using CarBookProject.Application.Features.CQRS.Commands.ContactCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand command) 
        {
            var values = await _repository.GetByIdAsync(command.ContactID);

            if ( values == null )
            {
                throw new Exception($"{command.ContactID}: Id data not exist in database.");
            }

            values.Subject = command.Subject;
            values.Message = command.Message;
            values.SentDate = command.SentDate;
            values.Name = command.Name;
            values.Email = command.Email;
            await _repository.UpdateAsync( values );
        }
    }
}
