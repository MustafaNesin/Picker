namespace Picker
{
    public class BuildMemory
    {
        public Build Build { get; set; }
        public int BuildId { get; set; }
        public int Id { get; private set; }
        public Memory Memory { get; set; }
        public int MemoryId { get; set; }
    }
}