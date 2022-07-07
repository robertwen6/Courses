package demo;

/**
 * @author rober
 */
public @interface MyAnnotation {
    String value() default "123";
}
