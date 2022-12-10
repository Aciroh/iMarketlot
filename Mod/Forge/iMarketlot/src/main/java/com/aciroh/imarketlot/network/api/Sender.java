package com.aciroh.imarketlot.network.api;

import com.aciroh.imarketlot.utils.LogHelper;

import java.io.IOException;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.Socket;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Sender {
    public static void sendStringToServer(final String string) {
        ExecutorService executorService = Executors.newFixedThreadPool(10);

        Runnable task = new Runnable() {
            @Override
            public void run() {
                try {
                    Socket socket = new Socket(InetAddress.getLocalHost(), 7777);
                    PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
                    out.println(string);
                } catch (IOException e) {
                    LogHelper.error(e);
                }
            }
        };

        executorService.submit(task);
    }
}
