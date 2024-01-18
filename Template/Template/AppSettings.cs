using System.ComponentModel.DataAnnotations;

namespace Template
{
    public class AppSettingsOptions
    {
        [Required]
        public TestObjectOptions TestObject { get; set; }
    }

    public class TestObjectOptions
    {
        [Required]
        [MinLength(15, ErrorMessage = "string should be longer than 14 characters")]
        public string TestValue { get; set; }
    }
}
