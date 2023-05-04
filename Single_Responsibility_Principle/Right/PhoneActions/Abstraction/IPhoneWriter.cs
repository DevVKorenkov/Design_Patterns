using Single_Responsibility_Principle.Models;

namespace Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

public interface IPhoneWriter
{
    void WriteToTxt(Phone phone, string fileName);
}