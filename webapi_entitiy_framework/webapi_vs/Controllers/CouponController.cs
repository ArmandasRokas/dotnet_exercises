using webapi_vs.Data;
using webapi_vs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace webapi_vs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CouponController : ControllerBase
    {
        PromotionsContext _promotionsContext;
        public CouponController(PromotionsContext promotionsContext)
        {
            _promotionsContext = promotionsContext;
        }

        [HttpGet]
        public IEnumerable<Coupon> Get()
        {
            return _promotionsContext.Coupons
                    .AsNoTracking()
                    .ToList();
        }
    }
}
