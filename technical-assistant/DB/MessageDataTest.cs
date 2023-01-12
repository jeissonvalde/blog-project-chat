using technical_assistant.Models;

namespace technical_assistant.DB
{
    public class MessageDataTest
    {
        // Find All Message
        public List<MessageModel> FindConversation(string userID)
        {
            var MessageList = new List<MessageModel>();

            MessageList.Add(new MessageModel() {
                MessageId = "0AD9J0A-2308J0F-239J2F0MI-S0D9",
                TransmitterName = "Asistente",
                ReceiverName = "Tí",
                Timestamp = DateTime.Now,
                Content = "Hola mucho gusto saludarte. Quiero presentarme, soy el Asistente técnico y estoy para servirte."
            });
            
            MessageList.Add(new MessageModel() {
                MessageId = "0AD08SDF08S-ASDF080J293P-ASD09F0MI-S0D9",
                TransmitterName = "Asistente",
                ReceiverName = "Tí",
                Timestamp = DateTime.Now,
                Content = "¿Cuál es tu inquietud?."
            });

            return MessageList;
        }
    }
}