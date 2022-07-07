package democollection;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;
import java.util.Iterator;

public class IteratorTest {
    @Test
    public void test1(){
        Collection<Object> c1 = new ArrayList<Object>();
        c1.add("A");
        c1.add(123);
        c1.add(new Date());
        System.out.println(c1);

        Iterator<Object> iterator = c1.iterator();

        while(iterator.hasNext()){
            if(iterator.next() == (Object) 123){
                iterator.remove();
            }
        }
        System.out.println(c1);
    }
}
