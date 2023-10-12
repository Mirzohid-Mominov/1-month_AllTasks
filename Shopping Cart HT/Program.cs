//using System.Xml.Linq;

//Shopping Cart - Online do'kon korzinkasi dasturini tuzing

//- mahsulotlar uchun Product tipini yarating
//- Product tipida Id ( unique value ), Name fieldlari bo'lsin
//- sotib olinayotgan mahsulotlarni boshqarish uchun ShoppingCart tipini yarating
//- unda mahsulotlar va ularni nechta sotib olinayotganini saqlovchi Items kolleksiyasi bo'lsin
//- Items kolleksiyasi o'zida mahsulot va uning sonini saqlab turadi
//- ShoppingCart da Add va Remove methodlari bo'lsin

//  Add - bu mahsulotlarni korzinkaga qo'shish uchun
//  - bu method hech nima qaytarmaydi
//  - uni product nomli Product tipidagi parameteri bo'lsin
//  - agar Items kolleksiyasida ushbu mahsulot allaqachon bo'lsa uni soni oshirilsin, aks holda yangi qo'shilsin

//  Remove - bu mahsulotlarni korzinkadan o'chirish uchun
//  - bu method boolean qiymat qaytaradi
//  - uni product nomli Product tipidagi parameteri bo'lsin
//  - agar Items kolleksiyasida ushbu mahsulot allaqachon bo'lsa uni soni kamaytirilsin va true qaytarilsin, aks holda false qaytsin

//1. Korzinka ni ishga tushirish
//- dastur boshida Product tipidan 3 ta object yarating
//- 3 ta product - mahsulotni ShoppingCartga qo'shing


using System;
using System.Text.RegularExpressions;

//- mahsulotlar uchun Product tipini yarating


//Shopping Cart - Online do'kon korzinkasi dasturini tuzing
//mahsulotlar uchun Product tipini yarating
//- Product tipida Id ( unique value ), Name fieldlari bo'lsin
//- sotib olinayotgan mahsulotlarni boshqarish uchun ShoppingCart tipini yarating
//- unda mahsulotlar va ularni nechta sotib olinayotganini saqlovchi Items kolleksiyasi bo'lsin
//- Items kolleksiyasi o'zida mahsulot va uning sonini saqlab turadi
//- ShoppingCart da Add va Remove methodlari bo'lsin

//  Add - bu mahsulotlarni korzinkaga qo'shish uchun
//  - bu method hech nima qaytarmaydi
//  - uni product nomli Product tipidagi parameteri bo'lsin
//  - agar Items kolleksiyasida ushbu mahsulot allaqachon bo'lsa uni soni oshirilsin, aks holda yangi qo'shilsin

//  Remove - bu mahsulotlarni korzinkadan o'chirish uchun
//  - bu method boolean qiymat qaytaradi
//  - uni product nomli Product tipidagi parameteri bo'lsin
//  - agar Items kolleksiyasida ushbu mahsulot allaqachon bo'lsa uni soni kamaytirilsin va true qaytarilsin, aks holda false qaytsin

//1. Korzinka ni ishga tushirish
//- dastur boshida Product tipidan 3 ta object yarating
//- 3 ta product - mahsulotni ShoppingCartga qo'shing



//product5

// product = 2
//product2 = 3;
//product3 = 5;
//product5 = 1

var m1 = new Product
{
Name = "banana",
Id = new Guid()
};

var m2 = new Product
{
Name = "apple",
Id = new Guid()
};

var m3 = new Product
{
Name = "potato",
Id = new Guid()
};

var items = new ShoppingCart();
items.Add(m1);
items.Add(m2);
items.Add(m3);


public class Product
{
    public Guid Id;
    public string Name;
}

public class ShoppingCart
{
    Dictionary<Product, int> Items = new Dictionary<Product, int>();
    public void Add(Product product)
    {

        var isFind = false;
        foreach (var item in Items)
        {
            if (item.Key.Name == product.Name)
            {
                Items[item.Key]++;
                isFind = true;
            }
        }
        if (!isFind)
        {
            Items.Add(product, 1);
        }
    }

    public bool Remove(Product product)
    {
        var isFind = false;
        foreach (var item in Items)
        {
            if (item.Key.Name == product.Name)
            {
                Items[item.Key]--;
                return true;
            }
        }
        return false;
    }
}







