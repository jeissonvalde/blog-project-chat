using System.ComponentModel.DataAnnotations;

namespace technical_assistant.Models
{
    public class MessageModel
    {
        public string MessageId { get; set; }
        public DateTime Timestamp { get; set; }

        [Required(ErrorMessage ="Es necesario conocer el emisor del mensaje.")]
        public string TransmitterId { get; set; }

        public string? TransmitterName { get; set; }

        [Required(ErrorMessage ="Es necesario conocer para quién va dirigido el mensaje.")]
        public string ReceiverId { get; set; }

        public string? ReceiverName { get; set; }

        [Required(ErrorMessage ="No está permitido un mensaje sin contenido.")]
        public string Content { get; set; }
    }
}
