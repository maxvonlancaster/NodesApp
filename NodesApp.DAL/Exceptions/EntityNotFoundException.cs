namespace NodesApp.DAL.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public Type EntityType { get; set; }

        public EntityNotFoundException(string? message) : base(message)
        {
        }

        public EntityNotFoundException(Type entityType)
        {
            EntityType = entityType;
        }
    }
}
