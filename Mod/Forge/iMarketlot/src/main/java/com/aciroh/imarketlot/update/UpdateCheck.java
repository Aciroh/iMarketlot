package com.aciroh.imarketlot.update;

import com.aciroh.imarketlot.reference.Reference;
import com.aciroh.imarketlot.reference.UpdateInfo;
import com.aciroh.imarketlot.utils.LogHelper;
import scala.collection.script.Update;

import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;

import static org.lwjgl.util.mapped.MappedObject.foreach;

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
            Scanner scanner = new Scanner(new URL(UpdateInfo.path).openStream());
            while (scanner.hasNextLine()) {
                UpdateInfo.file.add(scanner.nextLine());
            }
            scanner.close();
            if(!UpdateInfo.file.get(0).startsWith("0")) {
                UpdateInfo.error = true;
            } else {
                if(Reference.MOD_VERSION != UpdateInfo.file.get(0)){
                    UpdateInfo.isAvailable = true;
                    UpdateInfo.description = UpdateInfo.file.subList(1, (int) UpdateInfo.file.stream().count());
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
