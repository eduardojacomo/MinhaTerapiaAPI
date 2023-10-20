namespace minhaterapia.Models;

public class PacientesModel
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
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
    public int Codigo { get; set; }


    public PacientesModel()
    {

    }
}
