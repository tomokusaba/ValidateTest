using System.ComponentModel.DataAnnotations;

namespace ValidateTest
{
    internal class TestModel
    {
        [Required(ErrorMessage = "名前は必ず入力してください。")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "名前は３文字から１０文字入力してください。")]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
    }
}
