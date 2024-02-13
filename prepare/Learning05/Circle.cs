public class Circle : Shape{
    private double _raduis;

    public Circle(string color,double radius):base (color){
        _raduis = radius;
    }

    public override double GetArea(){
        return _raduis * _raduis * Math.PI;
    }
}