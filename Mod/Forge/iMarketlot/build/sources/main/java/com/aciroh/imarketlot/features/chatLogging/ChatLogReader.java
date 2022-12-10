package com.aciroh.imarketlot.features.chatLogging;

import com.aciroh.imarketlot.network.api.Sender;
import com.aciroh.imarketlot.utils.LogHelper;
import net.minecraftforge.client.event.ClientChatReceivedEvent;
import net.minecraftforge.fml.common.eventhandler.SubscribeEvent;

public class ChatLogReader {
    @SubscribeEvent
    public void onClientChatReceived(ClientChatReceivedEvent event) {
        // Get the message from the event
        ChatLogInfo.message = event.message.getUnformattedText();
        Sender.sendStringToServer(ChatLogInfo.message);
    }
}
