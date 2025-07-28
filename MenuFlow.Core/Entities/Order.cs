namespace MenuFlow.Core.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid TableId { get; private set; }
        public bool Status { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime? UpdateDate { get; private set; }
    }
}
