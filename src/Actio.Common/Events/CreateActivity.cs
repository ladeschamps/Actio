namespace Actio.Common.Events
{
    public class CreateActivity : IRejectedEvent
    {
        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }

        protected CreateActivity() 
        {
        }

        public CreateActivity(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }
    }
}