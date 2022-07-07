package demo;

public class EnumTest1 {
    public static void main(String[] args) {
        Season s = Season.SPRING;
    }
}

class Season{
    //属性用private final修饰
    private final String seasonName;

    //私有化构造器
    private Season(String seasonName){
        this.seasonName = seasonName;
    }

    //提供当前枚举类的多个对象
    public static final Season SPRING = new Season("春天");
    public static final Season SUMMER = new Season("夏天");
    public static final Season AUTUMN = new Season("秋天");
    public static final Season WINTER = new Season("冬天");
}
