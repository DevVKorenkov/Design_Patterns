using Single_Responsibility_Principle.Models;
using Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

namespace Single_Responsibility_Principle.Right.PhoneActions;

public class PhoneValidator : IPhoneValidator
{
    public bool IsValid(Phone phone) 
        => !string.IsNullOrWhiteSpace(phone.Model) && phone.Price > 0;
}