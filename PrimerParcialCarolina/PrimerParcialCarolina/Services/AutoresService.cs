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
            if(!await Existe(autores.AutorId))
            {
                return await Insertar(autores);
            }
            else
            {
                return await Modificar(autores);

            }
        }
        
         private async Task<bool> Existe (int AutorId)
         {
            await using var contexto = await contextFactory.CreateDbContextAsync();
            return await contexto.Autores.AnyAsync(a => a.AutorId == AutorId);
         }

          private async Task<bool> Insertar(Autores autores)
          {
            await using var contexto = await contextFactory.CreateDbContextAsync();
            contexto.Autores.Add(autores);
            return await contexto.SaveChangesAsync() > 0;

          }

          private async Task<bool> Modificar(Autores autores)
          {
            await using var contexto = await contextFactory.CreateDbContextAsync();
            contexto.Autores.Update(autores);
            return await contexto.SaveChangesAsync() > 0;

          }
        public async Task<Autores?> Buscar(int AutorId)
        {
            await using var contexto = await contextFactory.CreateDbContextAsync();
            return await contexto.Autores.AsNoTracking().FirstOrDefault(a => a.AutorId == AutorId);
        }

        public async Task<bool> Eliminar(int AutorId)
        {
            await using var contexto = await contextFactory.CreateDbContextAsync();
            return await contexto.Autores.Where(a => a.AutorId == AutorId).ExecuteDeleteAsync() > 0;//.where
        }

        public async Task<List<Autores>> GetList(Expression<Func<Autores, bool>> criterio)
        {
            await using var contexto = await contextFactory.CreateDbContextAsync();
            return await contexto.Autores.Where(criterio).AsNoTracking().ToListAsync();
        }

       
    }
}
