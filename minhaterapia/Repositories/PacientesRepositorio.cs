using Microsoft.EntityFrameworkCore;
using minhaterapia.Data;
using minhaterapia.Models;
using minhaterapia.Repositories.Interfaces;

namespace minhaterapia.Repositories
{
    public class PacientesRepositorio : IPacientesRepositorio
    {
        private readonly MinhaTerapiaDBContex _dBContext;
        public PacientesRepositorio(MinhaTerapiaDBContex minhaTerapiaDBContex)
        {
            _dBContext = minhaTerapiaDBContex;
        }

       

        public async Task<List<PacientesModel>> BuscarPacientes()
        {
            return await _dBContext.Pacientes.ToListAsync();
        }

        public async Task<List<ProfilePaciente>> PacientesCompleto()
        {
            //return await _dBContext.Pacientes.ToListAsync();
            var pacientecompleto = (from p in _dBContext.Pacientes
                                    join t in _dBContext.Terapia on p.Codigo equals t.CodigoPaciente
                             
                             select new ProfilePaciente()
                             {
                                 ID = p.ID,
                                 Nome = p.Nome,
                                 Cidade= p.Cidade,
                                 UF= p.UF,
                                 Endereco= p.Endereco,
                                 Numero = p.Numero,
                                 Complemento= p.Complemento,
                                 Bairro= p.Bairro,
                                 CEP= p.CEP,
                                 Celular= p.Celular,
                                 Email= p.Email,
                                 CPF= p.CPF,
                                 Sexo= p.Sexo,
                                 DataNascimento= p.DataNascimento,
                                 Codigo= p.Codigo,
                                 IdTerapia=t.Id,
                                 CodigoProfissional= t.CodigoProfissional,
                                 Status= t.Status,
                                 DiaTerapia = t.DiaTerapia,
                                 HoraTerapia = t.HoraTerapia,
                                 DataInicio= t.DataInicio,
                                 DataConclusao= t.DataConclusao,
                                 ValorTerapia= t.ValorTerapia,
                                 Vencimento = t.Vencimento,
                             }).ToListAsync();
            return await pacientecompleto;
        }

        public async Task<PacientesModel> BuscarPorID(int id)
        {
            return await _dBContext.Pacientes.FirstOrDefaultAsync(x => id == id);
        }

        public async Task<PacientesModel> Adicionar(PacientesModel pacientes)
        {
            await _dBContext.Pacientes.AddAsync(pacientes);
            await _dBContext.SaveChangesAsync();

            return pacientes;
        }

        public async Task<PacientesModel> Atualizar(PacientesModel pacientes, int id)
        {
            PacientesModel pacientePorId = await BuscarPorID(id);

            if (pacientePorId == null)
            {
                throw new Exception($"Paciente Id: {id} não encontrado");
            }
            pacientePorId.ID = pacientePorId.ID;
            pacientePorId.Nome = pacientes.Nome;
            pacientePorId.CPF = pacientes.CPF;
            pacientePorId.Codigo = pacientes.Codigo;
            pacientePorId.Celular= pacientes.Celular;
            pacientePorId.Sexo = pacientes.Sexo;
            pacientePorId.Email = pacientes.Email;
            pacientePorId.CEP = pacientes.CEP;
            pacientePorId.Endereco = pacientes.Endereco;
            pacientePorId.Numero = pacientes.Numero;
            pacientePorId.Complemento = pacientes.Complemento;
            pacientePorId.Bairro = pacientes.Bairro;
            pacientePorId.Cidade = pacientes.Cidade;
            pacientePorId.UF = pacientes.UF;
            pacientePorId.DataNascimento = pacientes.DataNascimento;
            pacientePorId.DataAlteracao = pacientes.DataAlteracao;
            pacientePorId.DataCadastro = pacientePorId.DataCadastro;
            

            _dBContext.Pacientes.Update(pacientePorId);
            await _dBContext.SaveChangesAsync();

            return pacientePorId;
        }

        public async Task<bool> Apagar(int id)
        {
            PacientesModel pacientePorId = await BuscarPorID(id);

            if (pacientePorId == null)
            {
                throw new Exception($"Paciente Id: {id} não encontrado");
            }
            _dBContext.Pacientes.Remove(pacientePorId);
            await _dBContext.SaveChangesAsync();

            return true;
        }

        

    }
}
