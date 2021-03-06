namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }

        protected CreateActivityRejected() 
        {
        }

        public CreateActivityRejected(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }
    }
}