using Single_Responsibility_Principle.Models;
using Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

namespace Single_Responsibility_Principle.Right.Store;

public class Store
{
    public IPhoneReader PhoneReader { get; set; }
    public IPhoneCreator PhoneCreator { get; set; }
    public IPhoneValidator PhoneValidator { get; set; }
    public IPhoneWriter PhoneWriter { get; set; }
    
    private List<Phone> _phones;

    public Store(
    IPhoneReader phoneReader, 
    IPhoneCreator phoneCreator, 
    IPhoneValidator phoneValidator, 
    IPhoneWriter phoneWriter)
    {
        _phones = new();

        PhoneReader = phoneReader;
        PhoneCreator = phoneCreator;
        PhoneValidator = phoneValidator;
        PhoneWriter = phoneWriter;
    }

    public void Process()
    {
        string?[] data = PhoneReader.GetInputData();
        var phone = PhoneCreator.CreatePhone(data);
        if (PhoneValidator.IsValid(phone))
        {
            _phones.Add(phone);
            PhoneWriter.WriteToTxt(phone, "phone.txt");
            Console.WriteLine("Data was added successfully");
        }
        else
        {
            Console.WriteLine("Input data was wrong");
        }
    }
}