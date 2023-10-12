//password yasash uchun PasswordGenerate service dan foydalaning
//- undan object olish uchun quyidagi parameterlar kerak bo'lsin 
//  - length
//  - hasLetters   
//  - hasDigits - optional
//- unda Generate methodi bo'lsin - parametersiz faqat generate bo'lgan password ni qaytaradigan
//- bitta object yarating, password yarating va ekranga chiqaring


using PasswordGenerate;
using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using System.Text;


var password = new Generate();

password.Generator(8, true, false);