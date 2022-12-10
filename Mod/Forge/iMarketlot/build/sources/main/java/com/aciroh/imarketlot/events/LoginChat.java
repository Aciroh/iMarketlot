package com.aciroh.imarketlot.events;

import com.aciroh.imarketlot.handlers.ConfigurationHandler;
import com.aciroh.imarketlot.reference.UpdateInfo;
import com.aciroh.imarketlot.update.UpdateChecked;
import com.aciroh.imarketlot.update.UpdateError;
import com.aciroh.imarketlot.update.UpdateSuccess;
import net.minecraftforge.fml.common.eventhandler.SubscribeEvent;
import net.minecraftforge.fml.common.gameevent.PlayerEvent;

public class LoginChat {
    boolean hasRunThisSession = false;
    @SubscribeEvent
    public void onPlayerLogin(PlayerEvent.PlayerLoggedInEvent event) {
        if(ConfigurationHandler.updateCheck) {
            if(UpdateInfo.error) {
                UpdateError.updateError(event);
            } else if(UpdateInfo.isAvailable){
                UpdateSuccess.updateSuccess(event);
            } else {
                UpdateChecked.updateChecked(event);
            }
        }
    }
}
