
namespace ProjectRagnarock.Models
{
    public class CodeRepository : ICodeRepository
    {
        private List<string> codes;

        public CodeRepository() 
        { 
            codes = new List<string>();
            codes.Add("1111");
            codes.Add("1112");
            codes.Add("2222");
            codes.Add("1234");
            codes.Add("3333");
            codes.Add("4444");
            codes.Add("9999");
            codes.Add("4321");
        }
        public List<string> GetAll() 
        { 
            return codes; 
        }
    }
}
