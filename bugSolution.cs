public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialized to 0

    public void MyMethod()
    {
        // Accessing a property that's been initialized
        int value = MyProperty * 2; 
    }
}