package demo;

import java.security.Provider;
import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.ThreadPoolExecutor;

class NumThread1 implements Runnable{
    @Override
    public void run() {
        for (int i = 0; i < 5; i++) {
            System.out.println(Thread.currentThread().getName() + " :" + i);
        }
    }
}

class NumThread2 implements Callable<Object>{
    @Override
    public Object call() throws Exception {
        for (int i = 5; i < 10; i++) {
            System.out.println(Thread.currentThread().getName() + " :" + i);
        }
        return null;
    }
}

public class ThreadPool {
    public static void main(String[] args) {
        ExecutorService executorService = Executors.newFixedThreadPool(10);
        //System.out.println(executorService.getClass());
        ThreadPoolExecutor service = (ThreadPoolExecutor)executorService;
        service.setCorePoolSize(10);

        executorService.execute(new NumThread1());
        executorService.submit(new NumThread2());

        executorService.shutdown();
    }
}
