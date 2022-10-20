public class ComplexNumber
{
    private float realNumber;
    private float imaginariumNumber;

    public ComplexNumber(float realNum, float imgNum)
    {
        realNumber = realNum;
        imaginariumNumber = imgNum;
    }

    public static ComplexNumber operator + (ComplexNumber a, ComplexNumber b)
    {
        ComplexNumber num = new ComplexNumber((a.realNumber + b.realNumber), (a.imaginariumNumber + b.imaginariumNumber));
        return num;
    }

    public override string ToString() => $"{this.realNumber} + {this.imaginariumNumber}i";
}