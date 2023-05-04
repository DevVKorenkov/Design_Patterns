using Single_Responsibility_Principle.Models;
using Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

namespace Single_Responsibility_Principle.Right.PhoneActions;

public class PhoneWriter : IPhoneWriter
{
    public void WriteToTxt(Phone phone, string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName, true))
        {
            sw.WriteLine(phone.Model);
            sw.WriteLine(phone.Price);
        }
    }
}