package demo;

import java.util.concurrent.CompletableFuture;

/**
 * @author RobertWen
 */
public class CommonEmployee extends Employee{
    @Override
    public void work() {
        System.out.println("CommonEmployee is working...");
    }
}
