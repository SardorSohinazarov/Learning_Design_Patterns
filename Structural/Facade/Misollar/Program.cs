// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qiyqiriq maqolalarim");
Console.WriteLine("https://t.me/sardorsohinazarov");

//26 #design_pattern
//4 #facade

//Facade - murakkab tizimlarga(library, framework yoki boshqa sinflar toplamiga) soddalashtirilgan interface taqdim etadi.

//Taxminan
//Iching qon yig'lasayam kulib tur.

//Tasavvur qiling telegram bot yozyapsiz (hechqanday library yo'q), hammasini ketma-ket bajarasiz: Botfatherdan token olish, botga http bilan get_update so'rovini qayta qayta jo'natishi, update bo'sh bo'lsa davom etishi, update bo'lsa shuni olib kerakli logikaga uzatish.

//Updateni Type ni bilishingiz kerak, message, callback yoki boshqa unknown.

//Callbackdan so'rovni olib keyingi qadamga o'tishi kerak.

//Message bo'lsachi, u nima? Rasm video audio hamma hammasini handle qilgandan keyin botga javob sifatida yana http bilan sendmessage.

//Hullas juda uzun, tushunarsiz, qiyin, chalkash code bo'ladi.

//Tayyor packagedan o'rnatib tokenni tashlab ishlatib qo'yganga nima yetsin.

//Shu murakkabliklarni yopib sodda xolga olib kelish oma lekin facadini chiroyli qib qo'yibti  degan gap so'zga sabab bo'ladida.

//#design #pattern




//27 #design_pattern
//2 #facade
//Facade(facadini chiroyli qilib qo'yadigan) pattern

//Yuqoridagi misol sal sodda bo'lib qoldida.

//Windows 11 os da o'tirib bitta faylni sichqoncha bilan yulib bir joydan boshqa joyga olib o'tib qo'yyapsiz lekin orqada qanday daxshatli operatsiyalar bo'layotganini 0 1 lar yugirib yurganini ko'rolmayapsiz. Chunki windows facadini chiroyli qilib qo'yganda.

//Yoki.net ef dan misol:

//var sixMonthsAgo = DateTime.UtcNow.AddMonths(-6);

//var customerStats = dbContext.Customers
//    .Where(c => c.Orders.Any(o => o.OrderDate >= sixMonthsAgo)) // Faqat oxirgi 6 oyda buyurtma qilganlar
//    .Select(c => new
//    {
//        CustomerId = c.CustomerId,
//        CustomerName = c.Name,
//        TotalSpent = c.Orders
//            .SelectMany(o => o.OrderItems)
//            .Sum(oi => oi.Quantity * oi.Price), // Jami sarflangan pul
//        LastOrderDate = c.Orders.Max(o => o.OrderDate) // So‘nggi buyurtma sanasi
//    })
//    .OrderByDescending(c => c.TotalSpent) // Saralash xarid summasi bo‘yicha
//    .ToList();

//yozib run tugmasini bosyapsizda. Orqada nima bo'lyapti farqi yo'q lekin ancha qiynalyapti bildirmayapti xalos.

//Expression Tree tuziladi,
//SQL ga tarjima qilinadi,
//Ma'lumotlar bazasiga so'rov jo'natiladi,
//Baza so'rovni bajarishini kutadi,
//EF Core natijalarni oladi va obyektlarga aylantiradi

//Ana shunday, uhlo'rdik endi a.

//#design #pattern



//28 #design_pattern
//3 #decorator
//Facade(facadini chiroyli qilib qo'yadigan) pattern

//Refactoring Guru(https://refactoring.guru/design-patterns/facade)
//YouTube video(https://youtu.be/gk0O83qCY30?si=BubbMycPinkZnvRt)

//#design #pattern