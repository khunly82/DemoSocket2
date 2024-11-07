namespace DemoSocket.DTO
{
    public class MessageDTO
    {
        public string Content { get; set; } = null!;
        public string Author { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
