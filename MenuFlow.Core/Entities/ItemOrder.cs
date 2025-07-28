namespace MenuFlow.Core.Entities
{
    public class ItemOrder
    {
        public Guid Id { get; private set; }
        public Guid OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public string Observation { get; private set; }
    }
}
