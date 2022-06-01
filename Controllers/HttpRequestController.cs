using CoreDataProtectionTutorial.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CoreDataProtectionTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpRequestController : Controller
    {
        private readonly IDataProtector _protector;

        public HttpRequestController(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("HttpRequestController");
        }

        [HttpPost("[action]")]
        public BaseResponseModel<ResModel> HttpReq([FromBody] ReqModel request )
        {
            if (!String.IsNullOrEmpty(request.input))
            {

           
            var userReq = request.input;
 
            var userResponse = new ResModel();
            userResponse.protectedRes =  _protector.Protect(userReq);
            userResponse.unProtecteddRes =  _protector.Unprotect(userResponse.protectedRes);


            var baseResponse = new BaseResponseModel<ResModel>();
            baseResponse.Data = userResponse;
            baseResponse.Message = "protection and unprotection completed";
            baseResponse.StatusCode = HttpStatusCode.OK;


            return baseResponse;
            }
            else
            {
                var baseResponse = new BaseResponseModel<ResModel>();
                baseResponse.Message = "protection and unprotection not completed";
                baseResponse.StatusCode = HttpStatusCode.BadRequest;

                return baseResponse;
            }
        }

    
    }
}
