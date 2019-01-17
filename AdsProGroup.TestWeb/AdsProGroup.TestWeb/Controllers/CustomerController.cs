using AdsProGroup.BusinessModels;
using AdsProGroup.Interfaces;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AdsProGroup.TestWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customService)
        {
            _customerService = customService;
        }
        // GET: Customer
        public async Task<ActionResult> Index()
        {
            var result = await _customerService.GetAllCustomers();

            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateCustomerInput input)
        {
            await _customerService.CreateCustomer(input);
            return Redirect("Index");
        }
    }
}