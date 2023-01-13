using technical_assistant.Models;


namespace technical_assistant.DB
{
    public class MessageDataTest
    {
        // List messages
        public List<MessageModel> InitialGreetings (string userID)
        {
            
            var MessageList = new List<MessageModel>();

            MessageList.Add(new MessageModel() {
                MessageId = "0AD9J0A-2308J0F-239J2F0MI-S0D9",
                TransmitterName = "Asistente",
                ReceiverName = "Usuario",
                Timestamp = DateTime.Now,
                Content = "Hola, estoy para servirte."
            });
            MessageList.Add(new MessageModel() {
                MessageId = "0AD08SDF08S-ASDF080J293P-ASD09F0MI-S0D9",
                TransmitterName = "Asistente",
                ReceiverName = "Usuario",
                Timestamp = DateTime.Now,
                Content = "¿Cuál es tu inquietud?."
            });
            

            return MessageList;
        }

        // 
        public List<ResponseModel> ResponsesAndMovements (string userID)
        {

            var MessageList = new List<ResponseModel>();

            MessageList.Add(new ResponseModel() {
                ResponseId = "0AD9J0A-2308J0F-239RES-1",
                Message = "Has solicitado cambiar entity_::::. wait_::4:: Te llevaré a navigate_path_::config_password::",
                ValuesToRead = "",
                RequiredContext = "c-1",
                Movement = "wait_4, navigate_path",
                FeedBack = ""
            });
            MessageList.Add(new ResponseModel() {
                ResponseId = "A9S0D7MJJF-AS97HA0F-239RES-2",
                Message = "Has solicitado cambiar número de teléfono. wait_::4:: Te llevaré a navigate_path_::config_phone::",
                ValuesToRead = "",
                RequiredContext = "c-1",
                Movement = "wait_4, navigate_path",
                FeedBack = ""
            });
            

            return MessageList;
        }
    }
}