package demo;

class Producer extends Thread {
    private Clerk clerk;
    public Producer(Clerk clerk){
        this.clerk = clerk;
    }

    @Override
    public void run() {
        System.out.println(getName() + " is producing...");

        while(true){
            try {
                Thread.sleep(10);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
            clerk.getProduct();
        }
    }
}

class Customer extends Thread{
    private Clerk clerk;
    public Customer(Clerk clerk){
        this.clerk = clerk;
    }

    @Override
    public void run() {
        System.out.println(getName() + " is buying...");

        while(true){
            try {
                Thread.sleep(20);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
            clerk.sellProduct();
        }
    }
}

class Clerk{
    private int productNum = 0;
    public synchronized void getProduct() {
        if(productNum < 20){
            productNum++;
            System.out.println(Thread.currentThread().getName() + " is producing" + productNum);
            notify();
        }
        else{
            try {
                wait();
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

    public synchronized void sellProduct() {
        if(productNum > 0){
            System.out.println(Thread.currentThread().getName() + " is buying" + productNum);
            productNum--;
            if(productNum < 10){
                notify();
            }
        }
        else{
            try {
                wait();
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}

public class ProducerAndCustomer {
    public static void main(String[] args) {
        Clerk clerk = new Clerk();

        Producer p = new Producer(clerk);
        p.setName("Producer");
        Customer c = new Customer(clerk);
        c.setName("Customer");

        p.start();
        c.start();
    }
}
