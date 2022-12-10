package com.aciroh.imarketlot.reference;

public class Reference {
    public static final String MOD_ID = "iMarketlot";
    public static final String MOD_NAME = "iMarketlot";
    public static final String MOD_VERSION = "0.0.1";

    //"before:modName" - loads before
    // "after:modName" - loads after
    // "requires-before:modName" - throws if mod not present
    // "required-after:modName" - throws if mod not present
    public static final String MOD_DEPENDENCIES = "required-after:Forge";
    public static final String MOD_ACCEPTED_MC_VERSIONS = "1.8.9";
    public static final String CLIENT_PROXY_CLASS = "com.aciroh.imarketlot.proxy.ClientProxy";
    public static final String SERVER_PROXY_CLASS = "com.aciroh.imarketlot.proxy.ServerProxy";
    public static final String GUI_FACTORY_CLASS = "com.aciroh.imarketlot.client.gui.GuiFactory";
}
