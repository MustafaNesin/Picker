namespace Picker
{
    using System.Windows.Forms;

    internal interface ISocketListView : IListView
    {
        string SocketBrand { get; }
        CheckState SocketSupportsDDR2 { get; }
        CheckState SocketSupportsDDR3 { get; }
        CheckState SocketSupportsDDR4 { get; }
    }
}