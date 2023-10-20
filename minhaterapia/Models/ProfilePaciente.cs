using minhaterapia.Enums;

namespace minhaterapia.Models;

public class ProfilePaciente
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public string UF { get; set; }
    public string Celular { get; set; }
    public string Sexo { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Endereco { get; set; }
    public string Numero { get; set; }
    public string? Complemento { get; set; }
    public string Bairro { get; set; }
    public string CPF { get; set; }
    public string CEP { get; set; }
    public string Email { get; set; }
    public int Codigo { get; set; }
    public int IdTerapia { get; set; }
    public int CodigoProfissional { get; set; }
    public StatusTerapia Status { get; set; }
    public string? DiaTerapia { get; set; }
    public string? HoraTerapia { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataConclusao { get; set; }
    public decimal? ValorTerapia { get; set; }
    public int? Vencimento { get; set; }
}
