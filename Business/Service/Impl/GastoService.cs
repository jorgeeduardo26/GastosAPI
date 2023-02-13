using Data.Persistence;
using Data.Repository;
using Data.Repository.Impl;
using Entity.Response;

namespace Business.Service.Impl
{
    public class GastoService : IGastoService
    {
        private IGenericRepository<Compra> repository = null;
        public GastoService()
        {
            this.repository = new GenericRepository<Compra>();
        }        

        public async Task<CommonResponse> Get()
        {
        var response = new CommonResponse { Code = 0, Message = "Ok" };
            try
            {
                var model =  repository.GetAll();
                response.Data = model;
            }
            catch (Exception ex)
            {
                                
            }

            return response;
        }
    }
}
