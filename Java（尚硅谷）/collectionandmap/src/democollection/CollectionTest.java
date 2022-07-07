package democollection;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Date;

public class CollectionTest {
    @Test
    public void test1(){
        Collection<Object> c1 = new ArrayList<Object>();
        c1.add("A");
        c1.add(123);
        c1.add(new Date());
        System.out.println(c1.size());

        Collection<Object> c2 = new ArrayList<Object>();
        c2.add(456);
        c2.add("BB");
        c1.addAll(c2);
        System.out.println(c1.size());
        System.out.println(c1);
        System.out.println("************************************");

//        c1.clear();
        System.out.println(c1.isEmpty());
        System.out.println(c1.contains(123));
        System.out.println(c1.containsAll(c2));
        System.out.println("************************************");

        c1.remove(123);
        System.out.println(c1);
        System.out.println("************************************");

        c1.removeAll(c2);
        System.out.println(c1);
        System.out.println("************************************");

        Collection<Object> c3 = new ArrayList<Object>();
        c3.add("A");
        c3.add("CCC");
        c1.retainAll(c3);
        System.out.println(c1);
        System.out.println(c1.equals(c3));
        System.out.println("************************************");

        Object[] objectArray = c1.toArray();
        for(Object o : objectArray){
            System.out.println(o);
        }
        System.out.println("************************************");

        Collection<Object> c4 = Arrays.asList(new String[]{"Q", "W", "E", "R"});
        System.out.println(c4);
    }
}
