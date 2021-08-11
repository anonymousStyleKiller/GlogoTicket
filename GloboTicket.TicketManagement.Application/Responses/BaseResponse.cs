using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Responses
{
    public class BaseResponse
    {
        protected BaseResponse() => Success = true;

        protected BaseResponse(string message = null)
        {
            Success = true;
            Message = message;
        }

        protected BaseResponse(string message, bool success)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        private string Message { get; }
        public List<string> ValidationErrors { get; set; }
    }
}