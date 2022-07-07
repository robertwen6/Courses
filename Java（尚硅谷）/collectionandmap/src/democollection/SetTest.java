package democollection;

import org.junit.Test;

import java.util.HashSet;
import java.util.TreeSet;

public class SetTest {
    @Test
    public void test1(){
        TreeSet<Integer> treeSet = new TreeSet<>();
        treeSet.add(1);
        treeSet.add(3);
        treeSet.add(8);
        treeSet.add(4);
        treeSet.add(2);
        System.out.println(treeSet);
    }
}

class Student{
    private String name;
    private int age;

    @Override
    public boolean equals(Object o) {
        if (this == o) {
            return true;
        }
        if (!(o instanceof Student)) {
            return false;
        }

        Student student = (Student) o;

        if (age != student.age) {
            return false;
        }
        return name != null ? name.equals(student.name) : student.name == null;
    }

    @Override
    public int hashCode() {
        int result = name != null ? name.hashCode() : 0;
        result = 31 * result + age;
        return result;
    }
}
