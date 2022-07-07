package demo;

import java.util.concurrent.*;

class MyThread implements Callable<Integer>{
    @Override
    public Integer call() throws Exception {
        int sum = 0;
        for (int i = 0; i < 100; i++) {
            if(i % 2 == 0){
                System.out.println(i);
                sum += i;
            }
        }
        return sum;
    }
}

public class CallableTest {
    public static void main(String[] args) {
        MyThread myThread = new MyThread();
        FutureTask<Integer> futureTask = new FutureTask<Integer>(myThread);

        new Thread(futureTask).start();

        try {
            int sum = futureTask.get();
            System.out.println(sum);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        } catch (ExecutionException e) {
            throw new RuntimeException(e);
        }
    }
}
