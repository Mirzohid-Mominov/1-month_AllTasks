using SmartHomeService_HT;

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


//- class types( sealed, abstract, static )
//-constructor types(default, parameterized, copy, static, private )
//-method parameter types(in, out, ref, params, optional, named )




SmartHome smartHome = new SmartHome(false, "Shittel", 100, 20);

smartHome.ExpectedTemperature = 30;
smartHome.CurrentTemperature = 23;
smartHome.DisplayHomeTemperature();