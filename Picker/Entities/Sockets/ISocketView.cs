namespace Picker
{
    internal interface ISocketView : IEntityView
    {
        Brand SocketBrand { get; set; }
        bool SocketSupportsDDR2 { get; set; }
        bool SocketSupportsDDR3 { get; set; }
        bool SocketSupportsDDR4 { get; set; }
    }
}