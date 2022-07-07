package demo;

public class SingletonPattern1 {
    public static void main(String[] args) {
        Bank b1 = Bank.getInstance();
    }
}

class Bank{
    /**私有化构造器*/
    private Bank(){

    }

    /**内部创建对象，static修饰*/
    private static Bank instance = new Bank();

    /**提供公共静态方法，返回对象*/
    public static Bank getInstance(){
        return instance;
    }
}
