using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Service;

public interface IRepositoryService<TEntity, IModel> where TEntity : class, new() where IModel : class
{
    Task<IList<IModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<IModel> InsertAsync(IModel model, CancellationToken cancellationToken);
    Task<IModel> UpdateAsync(long id, IModel model, CancellationToken cancellationToken);
    Task<IModel> DeleteAsync(long id, CancellationToken cancellationToken);
    Task<IModel> GetByIdAsync(long id, CancellationToken cancellationToken);
}
