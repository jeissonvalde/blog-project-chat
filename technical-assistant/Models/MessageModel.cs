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

    public class IntentModel
    {
        public string IntentId { get; set; }
        public DateTime Timestamp { get; set; }

        [Required(ErrorMessage ="Es necesario un mensaje de respuesta.")]
        public string Intent { get; set; }

        public int Person { get; set; }

        public string? Attribute { get; set; }

        public string? Value { get; set; }

        public string? Compare { get; set; }
    }

    public class ResponseModel
    {
        public string ResponseId { get; set; }
        // public DateTime Timestamp { get; set; }

        [Required(ErrorMessage ="Es necesario un mensaje de respuesta.")]
        public string Message { get; set; }

        public string? ValuesToRead { get; set; }

        public string? RequiredContext { get; set; }

        public string? Movement { get; set; }

        public string? FeedBack { get; set; }
    }

    public class FeedBackModel
    {
        public string FeedBackId { get; set; }
        // public DateTime Timestamp { get; set; }

        [Required(ErrorMessage ="Es necesario un mensaje de respuesta.")]
        public string Message { get; set; }

        public string? Response { get; set; }

        public string? Options { get; set; }
    }
}
