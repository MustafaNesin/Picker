namespace Picker
{
    using System.ComponentModel.DataAnnotations;

    public class BuildMemory
    {
        public int Id { get; private set; }
        public int BuildId { get; set; }
        public Build Build { get; set; }
        public int MemoryId { get; set; }
        public Memory Memory { get; set; }
    }
}