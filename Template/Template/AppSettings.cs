using System.ComponentModel.DataAnnotations;

namespace Template
{
    public class AppSettingsOptions
    {
        public required TestObjectOptions TestObject { get; set; }
    }

    public class TestObjectOptions
    {
        [MinLength(15, ErrorMessage = "string should be longer than 14 characters")]
        public required string TestValue { get; set; }
    }
}
