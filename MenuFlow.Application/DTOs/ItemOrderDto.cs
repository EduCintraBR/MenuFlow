namespace MenuFlow.Application.DTOs
{
    public class ItemOrderDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get;  set; }
        public int Quantity { get; set; }
        public string Observation { get; set; } = string.Empty;
    }
}
