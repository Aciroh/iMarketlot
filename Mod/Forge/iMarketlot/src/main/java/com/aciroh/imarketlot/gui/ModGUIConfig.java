package com.aciroh.imarketlot.gui;

import com.aciroh.imarketlot.reference.Reference;
import net.minecraft.client.gui.GuiScreen;
import net.minecraftforge.common.config.ConfigElement;
import net.minecraftforge.fml.client.config.GuiConfig;

import static com.aciroh.imarketlot.handlers.ConfigurationHandler.CATEGORY_UPDATECHECK;
import static com.aciroh.imarketlot.handlers.ConfigurationHandler.getConfiguration;

public class ModGUIConfig extends GuiConfig {
    public ModGUIConfig(GuiScreen guiScreen) {
        super(guiScreen,
                new ConfigElement(getConfiguration().getCategory(CATEGORY_UPDATECHECK)).getChildElements(),
                Reference.MOD_ID,
                false,
                false,
                GuiConfig.getAbridgedConfigPath(getConfiguration().toString())
        );
    }
}
