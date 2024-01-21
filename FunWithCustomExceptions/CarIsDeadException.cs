namespace FunWithCustomExceptions
{
    internal class CarIsDeadException : ApplicationException
    {
        private string? _messageDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; private set; }
        public string? CauseOfError { get; private set; }

        public CarIsDeadException()
        {
        }

        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            //_messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        //public override string Message => $"Car Error Message: {_messageDetails}";
        public override string Message => $"Car Error Message: {base.Message}";
    }
}