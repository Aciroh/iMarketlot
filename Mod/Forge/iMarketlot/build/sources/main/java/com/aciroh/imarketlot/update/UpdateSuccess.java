package com.aciroh.imarketlot.update;

import com.aciroh.imarketlot.reference.Reference;
import com.aciroh.imarketlot.reference.UpdateInfo;
import net.minecraft.util.ChatComponentText;
import net.minecraftforge.fml.common.gameevent.PlayerEvent;

public class UpdateSuccess {
    public static void updateSuccess(PlayerEvent.PlayerLoggedInEvent event) {
        event.player.addChatMessage(new ChatComponentText("iMarketlot SUCCESS"));
        event.player.addChatMessage(new ChatComponentText("The mod successfully checked for the latest version. Your version is: " + Reference.MOD_VERSION + " and the latest version is: " + UpdateInfo.file.get(0)));
    }
}
