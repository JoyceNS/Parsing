using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//this program ignores input validation
namespace Parsing
{

    class Program
    {
        static void Main(string[] args)
        {
            Parse.CheckConsecutive();
            Parse.CheckDuplicates();
            Parse.ValidTime();
            Parse.CreatePascal();
            Parse.CountVowels();
        }
    }
}
