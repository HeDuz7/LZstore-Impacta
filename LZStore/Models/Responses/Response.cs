using FluentValidation.Results;
using System.Collections.ObjectModel;

namespace LZStore.Models.Responses
{
    public class Response
    {

        private readonly IList<string> _mensages = new List<string>();

        public bool Success { get; set; }
        public IEnumerable<string> Notifications { get; }
        public object Result { get; set; }

        public Response(bool success = true)
        {
            Success = success;

            Notifications = new ReadOnlyCollection<string> (_mensages);
        }

        public Response(string notifiction, bool success = true) 
            : this(success) => _mensages.Add(notifiction); 

        public void AddInfo (string mensage, bool success = true)
        {
            Success = success;
            _mensages.Add (mensage);
        }

        public void AddError(string mensage)
        {
            Success = false;
            _mensages.Add(mensage);
        }

        public void AddError(IEnumerable<ValidationFailure> mensages)
        {
            foreach (var item in mensages)
            {
                AddError(item.ErrorMessage);
            }
        }

    }
}
