package demo;

/**
 * @author RobertWen
 */
public class Manager extends Employee{
    double bonus;

    public Manager(){
        super();
    }

    public Manager(String name, int id, int salary, double bonus){
        super(name, id, salary);
        this.bonus = bonus;
    }

    @Override
    public void work() {
        System.out.println("Manager is working...");
    }
}
