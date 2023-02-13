using System;
using System.Collections.Generic;

namespace Data.Persistence;

public partial class CatConcepto
{
    public int Id { get; set; }

    public string Valor { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();
}
