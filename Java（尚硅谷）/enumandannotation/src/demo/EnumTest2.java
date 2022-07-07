package demo;

public class EnumTest2 {
    public static void main(String[] args) {
        Vehicle[] values = Vehicle.values();
        for (Vehicle v : values) {
            System.out.println(v);
        }
    }
}

interface Info{
    void show();
}

enum Vehicle implements Info{
    Taxi("出租车"){
        @Override
        public void show() {
            System.out.println("taxi");
        }
    },
    Plane("飞机"){
        @Override
        public void show() {
            System.out.println("plane");
        }
    },
    Ship("船"){
        @Override
        public void show() {
            System.out.println("ship");
        }
    },
    Bus("公交车"){
        @Override
        public void show() {
            System.out.println("bus");
        }
    };

    private final String vehicleName;

    private Vehicle(String vehicleName){
        this.vehicleName = vehicleName;
    }
}