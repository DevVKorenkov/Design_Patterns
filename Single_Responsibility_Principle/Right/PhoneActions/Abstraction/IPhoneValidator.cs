using Single_Responsibility_Principle.Models;

namespace Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

public interface IPhoneValidator
{
    bool IsValid(Phone phone);
}