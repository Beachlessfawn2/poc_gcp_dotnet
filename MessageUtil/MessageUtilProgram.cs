using System;
using System.Threading;

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
            MessageUtilProgram mup = new MessageUtilProgram(@"         _             _                   _     _      _               _         _        
        / /\          /\_\               /\ \  /_/\    /\ \            /\ \      / /\      
       / /  \        / / /         _    /  \ \ \ \ \   \ \_\           \ \ \    / /  \     
      / / /\ \       \ \ \__      /\_\ / /\ \ \ \ \ \__/ / /           /\ \_\  / / /\ \__  
     / / /\ \ \       \ \___\    / / // / /\ \ \ \ \__ \/_/           / /\/_/ / / /\ \___\ 
    / / /  \ \ \       \__  /   / / // / /  \ \_\ \/_/\__/\          / / /    \ \ \ \/___/ 
   / / /___/ /\ \      / / /   / / // / /    \/_/  _/\/__\ \        / / /      \ \ \       
  / / /_____/ /\ \    / / /   / / // / /          / _/_/\ \ \      / / /   _    \ \ \      
 / /_________/\ \ \  / / /___/ / // / /________  / / /   \ \ \ ___/ / /__ /_/\__/ / /      
/ / /_       __\ \_\/ / /____\/ // / /_________\/ / /    /_/ //\__\/_/___\\ \/___/ /       
\_\___\     /____/_/\/_________/ \/____________/\/_/     \_\/ \/_________/ \_____\/        
                                                                                           ");
            Console.WriteLine("{0}", mup.Message);
            //mup.SaluteMessage(mup.Message);
            Thread.Sleep(60000);
        }
    }
}
