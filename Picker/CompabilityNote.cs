namespace Picker
{
    public class CompabilityNote
    {
        public bool IsIssue { get; }
        public string Message { get; }

        public CompabilityNote(bool isIssue, string message)
        {
            IsIssue = isIssue;
            Message = message;
        }

        public CompabilityNote(bool isIssue, string messageFormat, params object[] messageArgs)
        {
            IsIssue = isIssue;
            Message = string.Format(messageFormat, messageArgs);
        }
    }
}