namespace Application.Exceptions
{
    public class LoginFailException : Exception
    {
        public LoginFailException() : base()
        {
        }
        public LoginFailException(string userName) : base($"Login with user {userName} failed.")
        {
        }
        public LoginFailException(string userName, string? message) : base($"Login with user {userName} failed. {message}")
        {
        }
        public LoginFailException(string userName, string? message, Exception inner) :
            base("Login with user {userName} failed. {message}", inner)
        {
        }
     }
}