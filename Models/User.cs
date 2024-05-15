namespace ProjectRagnarock.Models
{
    public abstract class User
    {
        private string _username;

        public string Username
        { 
            get { return _username; } 
            set {  _username = value; } 
        }
    }
}
