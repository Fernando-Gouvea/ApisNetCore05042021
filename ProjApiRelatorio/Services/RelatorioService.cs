using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ProjApiRelatorio.Dto;
using Newtonsoft.Json;

namespace ProjApiRelatorio.Services
{
    public class RelatorioService
    {
        HttpClient httpClient = new HttpClient();
        IEnumerable<ClienteDto> lstCliente;
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
           httpClient.BaseAddress = new Uri("https://localhost:5001/api/Cliente");//usar 5000 e 5001 api cliente
            //https://localhost:5001/api/Cliente
            
        
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync("api/Cliente");

            if (response.IsSuccessStatusCode)
            {
                var clienteString = await response.Content.ReadAsStringAsync();
                lstCliente = JsonConvert.DeserializeObject<IEnumerable<ClienteDto>>(clienteString);
            }
            else{
                response.EnsureSuccessStatusCode();
            }
            
            return lstCliente;
        }


         HttpClient httpProduto = new HttpClient();
        IEnumerable<ProdutoDto> lstProduto;
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            httpProduto.BaseAddress = new Uri("http://localhost:5003/");// usar 5002 e 5003 api produto

            httpProduto.DefaultRequestHeaders.Accept.Clear();
            httpProduto.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync("api/Produto");

            if (response.IsSuccessStatusCode)
            {
                var produtoString = await response.Content.ReadAsStringAsync();
                lstProduto = JsonConvert.DeserializeObject<IEnumerable<ProdutoDto>>(produtoString);
            }
            else{
                response.EnsureSuccessStatusCode();
            }
            
            return lstProduto;
        }
    }
}