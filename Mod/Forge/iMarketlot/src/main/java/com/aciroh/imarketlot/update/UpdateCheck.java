package com.aciroh.imarketlot.update;

import com.aciroh.imarketlot.network.Reader;
import com.aciroh.imarketlot.reference.Reference;
import com.aciroh.imarketlot.reference.UpdateInfo;
import com.aciroh.imarketlot.utils.LogHelper;
import java.net.HttpURLConnection;
import java.net.URL;

public class UpdateCheck {
    public static void checkForUpdates() {
        try {
            HttpURLConnection connection = (HttpURLConnection) new URL(UpdateInfo.path).openConnection();
            connection.setRequestMethod("HEAD");
            int responseCode = connection.getResponseCode();
            LogHelper.info("UpdateChecker got response: " + responseCode);

            if (responseCode != 200) {
                UpdateInfo.error = true;
            }
            UpdateInfo.file = Reader.readFileFromURL(UpdateInfo.path);
            UpdateInfo.version = UpdateInfo.file.get(0);
            if(!UpdateInfo.version.startsWith("0")) {
                UpdateInfo.error = true;
            } else {
                if(!Reference.MOD_VERSION.equals(UpdateInfo.version)){
                    UpdateInfo.isAvailable = true;
                    UpdateInfo.description = UpdateInfo.file.subList(1, UpdateInfo.file.size());
                }
            }
        } catch (Exception e) {
            System.out.println("File not successfully read");
            throw new RuntimeException(e);
        }
    }
}
