namespace AddressBook.DL
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
