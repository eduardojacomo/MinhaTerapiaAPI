using System.ComponentModel;

namespace minhaterapia.Enums;

public enum StatusTerapia
{
    [Description("Começando a Terapia")]
    Novo = 1,
    [Description("Em tratamento")]
    EmTratamento = 2,
    [Description("Terapia pausada")]
    Pausado =3,
    [Description("Terapia concluida")]
    Concluido =4
}
