using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Response
{
    public class CommonResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public CommonResponse GetCommonResponse(int code,string message,object data = null)
        {
            return new CommonResponse
            {
                Code = code,
                Message = message,
                Data = data
            };
        }
    }
}
