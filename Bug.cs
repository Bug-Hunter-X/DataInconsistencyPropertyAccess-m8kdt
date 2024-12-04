public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Some code here
        int x = MyProperty; // Accessing MyProperty
        MyProperty = x + 1; // Modifying MyProperty
        // More code here
    }
}