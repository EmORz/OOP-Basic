namespace Telephony.Contracts
{
    public interface IPhone
    {
        string Model { get; set; }

        string Call(string phoneNumber);
    }
}
