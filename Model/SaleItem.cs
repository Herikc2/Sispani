namespace Sispani.Model
{
    public class SaleItem
    {
        public string ID { get; set; }
        public string VendaID { get; set; }
        public string ProdutoCodigoBarras { get; set; }
        public int Quantidade { get; set; }

        public SaleItem(string id, string vendaID, string produtoCodigoBarras, int quantidade)
        {
            ID = id;
            VendaID = vendaID;
            ProdutoCodigoBarras = produtoCodigoBarras;
            Quantidade = quantidade;
        }

        public SaleItem(string vendaID, string produtoCodigoBarras, int quantidade)
        {
            VendaID = vendaID;
            ProdutoCodigoBarras = produtoCodigoBarras;
            Quantidade = quantidade;
        }

        public SaleItem(string produtoCodigoBarras, int quantidade)
        {
            ProdutoCodigoBarras = produtoCodigoBarras;
            Quantidade = quantidade;
        }
    }
}
