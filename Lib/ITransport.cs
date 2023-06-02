namespace Lib
{
    public interface ITransport
    {
        int capacity { get; set; }
        string moveTransport();
        string stopTransport();
    }
}
