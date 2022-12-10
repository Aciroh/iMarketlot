package com.aciroh.imarketlot.network;

import com.aciroh.imarketlot.network.api.Sender;

import java.net.URL;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.logging.Logger;

public class Reader {
    private static final Logger logger = Logger.getLogger(Reader.class.getName());

    public static ArrayList<String> readFileFromURL(String urlString) throws Exception {
        // Create an empty ArrayList of Strings
        ArrayList<String> lines = new ArrayList<String>();

        // Open a connection to the URL and create a Scanner to read the contents
        URL url = new URL(urlString);
        Scanner scanner = new Scanner(url.openStream());

        // Read each line from the file and add it to the ArrayList
        while (scanner.hasNextLine()) {
            lines.add(scanner.nextLine());
        }

        // Close the scanner and log a success message
        scanner.close();
        logger.info("File successfully read from URL: " + urlString);

        // Return the ArrayList of lines
        return lines;
    }
}

