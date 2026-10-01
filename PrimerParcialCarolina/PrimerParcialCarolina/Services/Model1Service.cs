using Microsoft.EntityFrameworkCore;
using PrimerParcialCarolina.Context;
using PrimerParcialCarolina.Models;
using System.Linq.Expressions;

namespace PrimerParcialCarolina.Services
{
    public class Model1Service(IDbContextFactory<Contexto> contextFactory) : Aplicada1.Core.IService<Model1, int>
    {
         public Task<bool> Guardar(Model1 entidad)
        {
            throw new NotImplementedException();
        }
        
     //   private async Task<bool> Existe (int id)
       // {

        //}

       // private async Task<bool> Insertar(Model1 model1)
        //{

        //}

        //private async Task<bool> Modificar(Model1 model1)
        //{

        //}
        public Task<Model1?> Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model1>> GetList(Expression<Func<Model1, bool>> criterio)
        {
            throw new NotImplementedException();
        }

       
    }
}
