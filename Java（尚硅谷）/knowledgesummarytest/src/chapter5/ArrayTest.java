package chapter5;

public class ArrayTest {
    public static void main(String[] args) {
        int[][] array1 = new int[3][4];
        int[][] array2 = new int[3][];
        String[][] array3 = new String[][]{{"qw","we"},{"er","rt"}};
        int[][] array4 = {{1,2},{2,3}};

        System.out.println(array1[1]);
        System.out.println(array1[1][0]);

        System.out.println(array2[1]);
        System.out.println(array2[1][0]);
    }
}
