package demofile;

import org.junit.Test;

import java.io.File;

public class FileTest {
    @Test
    public void test1(){
        File file1 = new File("C:\\Users\\rober\\Desktop\\hello.txt");

        System.out.println(file1.getAbsolutePath());
        System.out.println(file1.getPath());
        System.out.println(file1.getName());
        System.out.println(file1.getParent());
        System.out.println(file1.length());
        System.out.println(file1.lastModified());

        File file2 = new File("D:\\±à³Ì½Ì³Ì");

        String[] list = file2.list();
        for(String str : list){
            System.out.println(str);
        }

        File[] files = file2.listFiles();
        for(File f : files){
            System.out.println(f);
        }
    }
}
