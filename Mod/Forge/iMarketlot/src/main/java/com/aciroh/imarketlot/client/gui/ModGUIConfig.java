package com.aciroh.imarketlot.client.gui;

import com.aciroh.imarketlot.reference.Reference;
import net.minecraft.client.gui.GuiScreen;
import net.minecraftforge.common.config.ConfigElement;
import net.minecraftforge.common.config.Configuration;
import net.minecraftforge.fml.client.config.GuiConfig;

import static com.aciroh.imarketlot.handlers.ConfigurationHandler.getConfiguration;

public class ModGUIConfig extends GuiConfig {
    public ModGUIConfig(GuiScreen guiScreen) {
        super(guiScreen,
                new ConfigElement(getConfiguration().getCategory(Configuration.CATEGORY_GENERAL)).getChildElements(),
                Reference.MOD_ID,
                false,
                false,
                GuiConfig.getAbridgedConfigPath(getConfiguration().toString())
        );
    }
}
