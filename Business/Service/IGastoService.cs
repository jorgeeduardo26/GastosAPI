using Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public  interface IGastoService

    {
        Task<CommonResponse> Get();
    }
}
