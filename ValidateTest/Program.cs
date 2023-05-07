using System.ComponentModel.DataAnnotations;
using ValidateTest;


TestModel model = new()
{
    Name = "name",
    Email = "fuga@hoge.com"
};

List<ValidationResult> errors = new();
bool isValid = Validator.TryValidateObject(model, new ValidationContext(model), errors, true);

if (isValid)
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
    foreach (var error in errors)
    {
        Console.WriteLine(error.ErrorMessage);
    }
}

