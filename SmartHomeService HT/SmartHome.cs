//-SmartHomeService dan foydalaning

//unda quyidagi propertylar bo'lsin 
//- IsActivated - hozir SmartHome ishlayotgan yoki yo'qligini bildiradi ( read-only )
//- DeviceName - o'rnatilgan Smart Home markaziy boshqaruv qurilmasi nomi ( init-only )
//- CurrentTemperature - temperatureni yozib borish uchun ( write-only )
//-ExpectedTemperature - foydalanuvchi xohlayotgan temperaturani sozlash ( read-write )

//unda quyidagi methodlar bo'lsin
//- Activate methodi yordamida ishga tushiriladigan ( activate ) qilinadigan bo'lsin
//- DisplayHomeTemperature - bunda vaqt davomida foydalanuvchi xohlagan va SmartHome ta'minlay olgan temperatura chiqsin

//- temperaturani expected va current qiymatlarini saqlash uchun Temperature modelidan foydalanish mumkin

namespace SmartHomeService_HT;

public class SmartHome
{
    private bool _isActivated;
    public bool IsActivated { get => _isActivated; }
    private string _deviceName { get; init; }
    private double _currentTemperature;
    
    private List<ValueTuple<double, double>> temperatures = new List<ValueTuple<double, double>>();

    private double _expectedTemperature;

    public double ExpectedTemperature 
    { 
        get { return _expectedTemperature; } 
        set { _expectedTemperature = value; } 
    }
    
    public double CurrentTemperature
    {
        set
        {
            _currentTemperature = value;
            temperatures.Add(new ValueTuple<double, double>(_currentTemperature, ExpectedTemperature));
        }
    }

    public SmartHome(bool isactivated, string devicename, double currenttemperature, double expectedtemperature)
    {
        _isActivated = isactivated;
        _deviceName = devicename;
        _currentTemperature = currenttemperature;
        _expectedTemperature = expectedtemperature;
        temperatures.Add(new ValueTuple<double, double>(currenttemperature, expectedtemperature));

    }

    public bool Activate(bool isactivate)
    {
        if (isactivate == false)
        {
            isactivate = true;
        }
        return isactivate;
    }

    public void DisplayHomeTemperature()
    {
        double temperature;
        try
        {
            temperature = temperatures.LastOrDefault().Item1;
        }
        catch 
        {
            Console.WriteLine("Current temperature not found.");
            return;
        }
        if (IsActivated == true)
            Console.WriteLine($"Device name : {_deviceName}\nStatus : Activated\nCurrent temperature : {temperature}");
        else
            Console.WriteLine($"Device name : {_deviceName}\nStatus : Not Activated\nCurrent temperature : {temperature}");
    }

    /*public string display(string fullname)
    {
        Console.WriteLine(fullname);
        return fullname;
    }*/
}





//Exmaple

//foydaluvchi xohlagan va SmartHome ta'minlay olgan temperaturani quyidagicha dastur o'zida kiritsangiz bo'ladi

//ExpectedTemperature = 20
//CurrentTemperature = 22
//CurrentTemperature = 23
//CurrentTemperature = 21
//CurrentTemperature = 20
//ExpectedTemperature = 25
//CurrentTemperature = 21
//CurrentTemperature = 22
//CurrentTemperature = 23

//DisplayHomeTemperature natijasi 

//Expected - 20, Current - 22
//Expected - 20, Current - 23
//Expected - 20, Current - 21
//Expected - 20, Current - 20
//Expected - 25, Current - 21
//Expected - 25, Current - 22
//Expected - 25, Current - 23




