package com.aciroh.imarketlot.handlers;

import com.aciroh.imarketlot.reference.Reference;
import net.minecraftforge.common.config.Configuration;
import net.minecraftforge.fml.client.event.ConfigChangedEvent;
import net.minecraftforge.fml.common.eventhandler.SubscribeEvent;

import java.io.File;

public class ConfigurationHandler {
    public static Configuration configuration;

    public static String CATEGORY_UPDATECHECK = "Update Check";

    public static boolean updateCheck = true;

    public static void init(String configDir) {
        if (configuration == null) {
            File path = new File(configDir + Reference.MOD_ID + ".cfg");

            configuration = new Configuration(path);

            loadConfiguration();
        }
    }

    private static void loadConfiguration() {
        updateCheck = configuration.getBoolean("checkForUpdates", CATEGORY_UPDATECHECK, true, "Allow this mod to check for updates?");

        if (configuration.hasChanged()) {
            configuration.save();
        }
    }

    public static Configuration getConfiguration() {
        return configuration;
    }

    @SubscribeEvent
    public void onConfigurationChangeEvent(ConfigChangedEvent.OnConfigChangedEvent event) {
        if (event.modID.equalsIgnoreCase(Reference.MOD_ID)) {
            loadConfiguration();
        }
    }
}
