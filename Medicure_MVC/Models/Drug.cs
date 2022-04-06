namespace Medicure_MVC.Models
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Supplier_Qty { get; set; }
        public int Salesmen_Qty { get; set; }
        public float Price{ get; set; }

    }
}
