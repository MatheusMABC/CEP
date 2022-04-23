using CEP.Models;

namespace CEP.Services
{
    public interface ICepService
    {
        Task<Cep>  ConsultarCep(string cep);
    }
}
