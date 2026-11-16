class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Jon", 195, 90, "Metric");
        BMICalculator cal = new BMICalculator();
        cal.Calculate(person);
    }
}