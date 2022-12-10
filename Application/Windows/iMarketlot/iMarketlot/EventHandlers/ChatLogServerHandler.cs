using iMarketlot.API;
using iMarketlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace iMarketlot.EventHandlers
{
    internal class ChatLogServerHandler
    {
        private FormiMarketlot form;
        private ChatLogServer server = null;
        private Thread serverThread = null;

        public ChatLogServerHandler(FormiMarketlot form) {
            this.form = form;
            server = new ChatLogServer();
            //form.Shown += subscribeToEvents;
            subscribeToEvents();
            serverThread = new Thread(server.startServer);
            serverThread.Start();
        }
        public void subscribeToEvents(object sender, EventArgs e)
        {
            ChatLogServer.receivedMessage += receivedMessageEventHandler;
            ChatLogServer.serverStarted += serverStartedEventHandler;
        }

        public void subscribeToEvents()
        {
            ChatLogServer.receivedMessage += receivedMessageEventHandler;
            ChatLogServer.serverStarted += serverStartedEventHandler;
        }

        private void serverStartedEventHandler(object sender, EventArgs e)
        { 
            form.setPictureboxServerStatus(server.getServerStatus());
            form.setLabelServerIPValue(server.getIPAddress());
        }

        private void receivedMessageEventHandler(object sender, EventArgs e)
        {
            form.setRTBChatLogText(server.getReceivedMessages());
        }
    }
}
