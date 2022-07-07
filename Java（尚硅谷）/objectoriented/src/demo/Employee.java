package demo;

/**
 * @author RobertWen
 */
public abstract class Employee {
    private String name;
    private int id;
    private double salary;

    public Employee(){

    }

    public Employee(String name, int id, int salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    /**
     * work是抽象方法
     */
    public abstract void work();
}