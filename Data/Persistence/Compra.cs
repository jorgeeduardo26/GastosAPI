using System;
using System.Collections.Generic;

namespace Data.Persistence;

public partial class Compra
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string? Comentario { get; set; }

    public string? Imagen { get; set; }

    public decimal Total { get; set; }

    public int CatConceptoId { get; set; }

    public virtual CatConcepto CatConcepto { get; set; } = null!;
}
