using CEP.Context;
using CEP.Models;
using System.Dynamic;
using System.Text.Json;

namespace CEP.Services
{
    public class CepService : ICepService
    {
        private readonly DBContext _context;

        public CepService(DBContext context)
        {
            _context = context;
        }
        public async Task<Cep> ConsultarCep(string cep)
        {
            var cepObjeto = new Cep();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");
                var httpProdutoResponse = await client.GetAsync($"" + cep + "/json/");
                if (httpProdutoResponse.IsSuccessStatusCode)
                {
                    var teste = JsonSerializer.Deserialize<ExpandoObject>(await httpProdutoResponse.Content.ReadAsStringAsync());

                    cepObjeto = JsonSerializer.Deserialize<Models.Cep>(await httpProdutoResponse.Content.ReadAsStringAsync());
                   await Create(cepObjeto);
                }
            }
            return cepObjeto;



        }

        public async Task Create(Cep cep)
        {
            try
            {
                

                if (cep.Id == 0)
                {
                 
                    await _context.AddAsync(cep);
                }
                else
                {
                    _context.Entry(cep).Property(x => x.Id).IsModified = false;

                    _context.Update(cep);

                }

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }
}
