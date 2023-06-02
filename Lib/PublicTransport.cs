namespace Lib
{
    public abstract class PublicTransport : ITransport
    {
        public int capacity { get; set; }
        public int number { get; set; }
        public int power { get; set; }

        public string moveTransport()
        {
            return "Transport is moving";
        }


        public string stopTransport()
        {
            return "Transport stops";
        }
        

        public abstract string Move();
    }
}
