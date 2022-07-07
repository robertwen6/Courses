package demomap;

import org.junit.Test;

import java.util.Collection;
import java.util.HashMap;
import java.util.Map;

public class MapTest {
    @Test
    public void test1(){
        Map<String, Integer> map = new HashMap<>();
        map.put("A", 1);
        map.put("B", 2);
        System.out.println(map);
    }
}
