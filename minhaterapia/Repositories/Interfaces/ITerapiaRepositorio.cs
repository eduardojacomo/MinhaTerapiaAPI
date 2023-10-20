using minhaterapia.Models;

namespace minhaterapia.Repositories.Interfaces;

public interface ITerapiaRepositorio
{
    Task<List<TerapiaModel>> BuscarTerapia();
    Task<TerapiaModel> BuscarPorID(int id);
    Task<TerapiaModel> Adicionar(TerapiaModel terapia);
    Task<TerapiaModel> Atualizar(TerapiaModel terapia, int id);
    Task<bool> Apagar(int id);


}
