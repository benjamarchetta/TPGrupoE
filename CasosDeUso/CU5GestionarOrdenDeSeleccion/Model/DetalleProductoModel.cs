namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;

internal class DetalleProductoModel //SUpongamos que esto me queda IGUAL a la entidad producto.
{
    public int IdProducto { get; set; }
    public string Sku { get; set; }
    public string DescripcionProducto { get; set; }
    public int Cantidad { get; set; }
    public bool PalletCerrado { get; set; }
    public string Ubicacion { get; set; }
}