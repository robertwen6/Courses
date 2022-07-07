package democollection;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class ListTest {
    @Test
    public void test1(){
        ArrayList<Object> arrayList1 = new ArrayList<>();
        arrayList1.add(1);
        arrayList1.add("A");
        arrayList1.add(new Date());
        List<Object> list1 = arrayList1.subList(0,2);
        System.out.println(list1);

        arrayList1.remove(1);
        System.out.println(arrayList1);

        arrayList1.set(1, "B");
        System.out.println(arrayList1);
    }
}
