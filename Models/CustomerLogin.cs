namespace ProjectRagnarock.Models
{
    public class CustomerLogin
    {
        public List<String> Codes;

        public CustomerLogin() 
        {
            Codes = new List<String>() {new string ("1111"), new string("2222") };
        }
        public bool Validation(string pin) 
        { 
            foreach (var item in Codes) 
            {
                if (item == pin)
                { 
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            return false;
        }
    }
}
