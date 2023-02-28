using ClassLibrary;
using ClassLibrary.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IArrayServices _arrayServices;

        public IndexModel(ILogger<IndexModel> logger, IArrayServices arrayServices)
        {

            _logger = logger;
            _arrayServices = arrayServices;
        }

        public List<int> GetFindTheLargestThree(int[] inputArray)
        {
            int[] ints = _arrayServices.FindTheLargestThree(inputArray);
            return ints.ToList();
        }

        public List<int> FindTheLargestThreeUsingSort(int[] inputArray)
        {
            int[] ints = _arrayServices.FindTheLargestThreeUsingSort(inputArray);
            return ints.ToList();
        }

        public string ReverseString(string inputstr)
        {
           return _arrayServices.ReverseString(inputstr);
        }
    }
}