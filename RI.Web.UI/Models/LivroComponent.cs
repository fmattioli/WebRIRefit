namespace RI.Web.UI.Models
{
    public class LivroComponent
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}