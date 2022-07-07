package chapter4;

public class SwitchCaseTest {
    public static void main(String[] args) {
        int num = 3;
        int result = 0;
        switch (num){
            case 0:
                result += 0;
                break;
            case 1:
                result += 1;
                break;
            case 2:
                result += 2;
                break;
            case 3:
                result += 3;
                break;
            default:
                break;
        }
    }
}
