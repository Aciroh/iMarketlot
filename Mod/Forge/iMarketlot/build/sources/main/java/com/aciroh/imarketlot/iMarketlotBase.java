package com.aciroh.imarketlot;


import com.aciroh.imarketlot.events.LoginChat;
import com.aciroh.imarketlot.features.chatLogging.ChatLogReader;
import com.aciroh.imarketlot.handlers.ConfigurationHandler;
import com.aciroh.imarketlot.proxy.IProxy;
import com.aciroh.imarketlot.reference.Reference;
import com.aciroh.imarketlot.utils.LogHelper;
import net.minecraft.client.Minecraft;
import net.minecraftforge.client.event.ClientChatReceivedEvent;
import net.minecraftforge.common.MinecraftForge;
import net.minecraftforge.fml.common.Mod;
import net.minecraftforge.fml.common.SidedProxy;
import net.minecraftforge.fml.common.event.FMLInitializationEvent;
import net.minecraftforge.fml.common.event.FMLPostInitializationEvent;
import net.minecraftforge.fml.common.event.FMLPreInitializationEvent;
import net.minecraftforge.fml.common.eventhandler.SubscribeEvent;

@Mod(
        modid = Reference.MOD_ID,
        name = Reference.MOD_NAME,
        version = Reference.MOD_VERSION,
        dependencies = Reference.MOD_DEPENDENCIES,
        acceptedMinecraftVersions = Reference.MOD_ACCEPTED_MC_VERSIONS,
        canBeDeactivated = true,
        guiFactory = Reference.GUI_FACTORY_CLASS
)
public class iMarketlotBase {
    @Mod.Instance(Reference.MOD_ID)
    public static iMarketlotBase instance = new iMarketlotBase();

    @SidedProxy(clientSide = Reference.CLIENT_PROXY_CLASS, serverSide = Reference.SERVER_PROXY_CLASS)
    public static IProxy proxy;

    @Mod.EventHandler
    public static void preInit(FMLPreInitializationEvent event) {
        String configDir = event.getModConfigurationDirectory().toString();
        ConfigurationHandler.init(configDir);
        MinecraftForge.EVENT_BUS.register(new ConfigurationHandler());
        MinecraftForge.EVENT_BUS.register(new LoginChat());
        MinecraftForge.EVENT_BUS.register(new ChatLogReader());

        LogHelper.info("Pre Initialization of iMarketlot");
    }

    @Mod.EventHandler
    public static void init(FMLInitializationEvent event) {
        LogHelper.info("Initialization of iMarketlot");
    }

    @Mod.EventHandler
    public static void postInit(FMLPostInitializationEvent event) {
        LogHelper.info("Post Initialization of iMarketlot");
    }
}
