using technical_assistant.Models;
using System.Data.SqlClient;
using System.Data;

namespace technical_assistant.DB
{
    public class MessageData
    {
        // Find All Message
        public List<MessageModel> FindConversation(string userID) {
            var MessageList = new List<MessageModel>();
            var connection = new Connection();

            using (var conn = new SqlConnection(connection.getSQLConnectionData())) {
                conn.Open();
                // Script of SQL server: conversation_by_user_id. This is a stored procedure.
                SqlCommand cmd = new SqlCommand("conversation_by_user_id", conn);
                // Find Conversation by userID
                cmd.Parameters.AddWithValue("userID", userID);
                cmd.CommandType = CommandType.StoredProcedure;

                // Read db messages table.
                using (var messageData = cmd.ExecuteReader()) {

                    // Take each data row
                    while (messageData.Read())
                    {
                        MessageList.Add(new MessageModel() {
                            /*
                                In some MySQL databases, data is recorded with an integer id. 
                                The problem with this is, it can be easy for you to identify and 
                                therefore delete the information either due to a malware attack or 
                                a development error. The solution to this is to handle Universally 
                                Unique Identifier.
                            */
                            MessageId = (string)messageData["MessageId"],
                            TransmitterName = (string)messageData["TransmitterName"],
                            ReceiverName = (string)messageData["ReceiverName"],
                            Timestamp = (DateTime)messageData["Timestamp"],
                            Content = (string)messageData["Content"]
                        });
                    }
                }
            }

            return MessageList;
        }

        // Save message
        public bool SaveMessage (MessageModel message_data) {
            bool res;

            try {
                var connection = new Connection();
                using (var conn = new SqlConnection(connection.getSQLConnectionData())) {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("conversation_push_message", conn);
                    DateTime savedAt = DateTime.Now;

                    // Set data
                    cmd.Parameters.AddWithValue("MessageId", message_data.MessageId);
                    cmd.Parameters.AddWithValue("Timestamp", savedAt);
                    cmd.Parameters.AddWithValue("TransmitterId", message_data.TransmitterId);
                    cmd.Parameters.AddWithValue("TransmitterName", message_data.TransmitterName);
                    cmd.Parameters.AddWithValue("ReceiverId", message_data.ReceiverId);
                    cmd.Parameters.AddWithValue("ReceiverName", message_data.ReceiverName);
                    cmd.Parameters.AddWithValue("Content", message_data.Content);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                res = true;
            } catch (Exception e) {
                string Error = e.Message;
                res = false;
            }

            return res;
        }
    }
}
