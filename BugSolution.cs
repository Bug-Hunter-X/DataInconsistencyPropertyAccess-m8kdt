public class ExampleClass
{
    private int _myField;
    private readonly object _lock = new object(); // Lock object

    public int MyProperty
    {
        get
        {
            lock (_lock)
            {
                return _myField;
            }
        }
        set
        {
            lock (_lock)
            {
                _myField = value;
            }
        }
    }

    public void MyMethod()
    {
        int x;
        lock (_lock)
        {
            x = MyProperty; // Accessing MyProperty
            MyProperty = x + 1; // Modifying MyProperty
        }
        // More code here
    }
}