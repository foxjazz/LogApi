using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogApi.Controllers
{
    public class LogController : Controller
    {
        // GET: /<controller>/

        [HttpPost("LogData")]
        [ProducesResponseType(400)]
        public HttpResponseMessage LogData ([FromBody] Model.LogData str)
        {
            if (str == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            try
            {
                Repo.writeLog(str.Log);
                return new HttpResponseMessage(HttpStatusCode.Accepted);
            }
            catch (Exception ex)
            {
                var bad = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                bad.Content = new StringContent("{Exception\": \"" + ex.Message + "\"}");

                return bad;
            }
        }
    }
}
