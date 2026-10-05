using Microsoft.EntityFrameworkCore;
using PrimerParcialCarolina.Context;
using PrimerParcialCarolina.Models;
using System.Linq.Expressions;

namespace PrimerParcialCarolina.Services
{
    public class AutoresService(IDbContextFactory<Contexto> contextFactory) : Aplicada1.Core.IService<Autores, int>
    {
         public async Task<bool> Guardar(Autores autores)
        {
            if(!await Existe)
        }
        
         private async Task<bool> Existe (int id)
         {

         }

          private async Task<bool> Insertar(Model1 model1)
          {

          }

          private async Task<bool> Modificar(Model1 model1)
          {

          }
        public Task<Autores?> Buscar(int id)
        {
            throw new NotImplementedException();//.asnottracking.firstordefault
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();//.where
        }

        public Task<List<Autores>> GetList(Expression<Func<Autores, bool>> criterio)
        {
            throw new NotImplementedException();//.where
        }

       
    }
}
