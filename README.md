# VeelenSoft.Validation



## Example

``` csharp
private class NewProductValidator : Validator<Product>
{
        public NewProductValidator()
        {
                Rule().Should(new ProductNotExists()).WithValidationMessage("Product already exists");
                RuleFor(o => o.Name).IsNotEmpty().WithValidationMessage("Name is empty."));
                RuleFor(o => o.IssueDate).IsNotInThePast().WithValidationMessage("date error").ExceptWhen(o => o.Name.StartsWith("_old"));
        }
}
``` 

``` csharp
var validator = new NewProductValidator();
var result = validator.Validate(new Product { Name = "test", IssueDate = new DateTime(2017,1,1)});
if(result.IsValid)
{
        // do someting
}
```