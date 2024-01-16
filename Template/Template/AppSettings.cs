namespace Template
{
    public class AppSettingsOptions
    {
        public required TestObjectOptions TestObject { get; set; }
    }

    public class TestObjectOptions
    {
        public required string TestValue { get; set; }
    }
}
