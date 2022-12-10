package com.aciroh.imarketlot.update;


import net.minecraft.util.ChatComponentText;
import net.minecraftforge.fml.common.gameevent.PlayerEvent;

public class UpdateError {
    public static void updateError(PlayerEvent.PlayerLoggedInEvent event) {
        event.player.addChatMessage(new ChatComponentText("iMarketlot ERROR"));
        event.player.addChatMessage(new ChatComponentText("There was an error connecting to the update server"));
    }
}
