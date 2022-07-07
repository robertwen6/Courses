package demo;

public class SingletonPattern2 {
    public static void main(String[] args) {
        Order o1 = Order.getInstance();
    }
}

class Order{
    private Order(){

    }

    private static Order instance = null;

    public static Order getInstance(){
        if(instance == null){
            instance = new Order();
        }
        return instance;
    }
}
