package com.aciroh.imarketlot.update;

import com.aciroh.imarketlot.reference.Reference;
import com.aciroh.imarketlot.reference.UpdateInfo;
import net.minecraft.util.ChatComponentText;
import net.minecraftforge.fml.common.gameevent.PlayerEvent;

public class UpdateChecked {
    public static void updateChecked(PlayerEvent.PlayerLoggedInEvent event) {
        event.player.addChatMessage(new ChatComponentText("iMarketlot CHECKED"));
        event.player.addChatMessage(new ChatComponentText("Your version: " + Reference.MOD_VERSION + " Latest version: " + UpdateInfo.version));
    }
}
