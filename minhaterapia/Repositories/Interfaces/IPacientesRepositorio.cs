using minhaterapia.Models;

namespace minhaterapia.Repositories.Interfaces;

public interface IPacientesRepositorio
{
    Task<List<PacientesModel>> BuscarPacientes();
    Task<List<ProfilePaciente>> PacientesCompleto();

    Task<PacientesModel> BuscarPorID(int id);
    Task<PacientesModel> Adicionar(PacientesModel pacientes);
    Task<PacientesModel> Atualizar(PacientesModel pacientes, int id);
    Task<bool> Apagar(int id);



}
