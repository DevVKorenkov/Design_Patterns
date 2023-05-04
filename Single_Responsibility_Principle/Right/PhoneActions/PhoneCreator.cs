using Single_Responsibility_Principle.Models;
using Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

namespace Single_Responsibility_Principle.Right.PhoneActions;

public class PhoneCreator : IPhoneCreator
{
    public Phone CreatePhone(string?[] data)
    {
        if (data is [string model, _] && double.TryParse(data[1], out double price))
        {
            return new Phone(model, price);
        }

        throw new Exception("Input data is wrong.");
    }
}