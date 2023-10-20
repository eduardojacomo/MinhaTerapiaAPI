using minhaterapia.Enums;

namespace minhaterapia.Models;

public class TerapiaModel
{
    public int Id { get; set; }
    public int CodigoPaciente { get; set; }
    public int CodigoProfissional { get; set; }
    public StatusTerapia Status { get; set; }
    public string DiaTerapia { get; set; }
    public string HoraTerapia { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataConclusao { get; set; }
    public decimal ValorTerapia { get; set; }
    public int Vencimento { get; set; }

    public TerapiaModel()
    {

    }
}
