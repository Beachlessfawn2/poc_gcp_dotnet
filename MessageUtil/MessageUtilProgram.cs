using System;

namespace MessageUtil
{
    public class MessageUtilProgram
    {
        private String p_message;
        private MessageUtilProgram() { }
        public MessageUtilProgram(String message) {
            p_message = message;
        }
        public String Message
        {
            get { return p_message; }
        }
        public String SaluteMessage(String m)
        {
            Console.WriteLine("Hello\n${0}", m);
            return "hello" + m;
        }
        static void Main(string[] args)
        {
            MessageUtilProgram mup = new MessageUtilProgram("");
            Console.WriteLine("${0}", mup.Message);
            mup.SaluteMessage(mup.Message);
        }
    }
}
