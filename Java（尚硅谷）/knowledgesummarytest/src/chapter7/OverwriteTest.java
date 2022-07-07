package chapter7;

public class OverwriteTest {
    public static void main(String[] args) {
        B.getX(1);
    }
}
class A{
    private void f1(){
        System.out.println("qwer");
    }
    public static void getX(int x){
        System.out.println(x);
    }
}

class B extends A{
    public static void getX(int x){
        System.out.println(x + 1);
    }
}
