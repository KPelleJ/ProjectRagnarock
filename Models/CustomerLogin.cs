namespace ProjectRagnarock.Models
{
    public class CustomerLogin
    {
        public ICodeRepository CodeRepo;
        private List<string> Codes;

        public CustomerLogin(ICodeRepository codeRepo) 
        {
            CodeRepo = codeRepo;
            Codes = codeRepo.GetAll();
            
        }
        //Her validere vi den pin der bliver skrevet ude i Index siden.
        public bool Validation(string pin) 
        { 
            foreach (var item in Codes) 
            {
                if (item == pin)
                { 
                    return true;
                }
            }
            return false;
        }
    }
}
