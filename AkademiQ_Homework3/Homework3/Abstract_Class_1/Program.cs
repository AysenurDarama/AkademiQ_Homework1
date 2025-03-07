/* ABSTRACT CLASS NEDİR?
 * Abstract class başka sınıfların türetilmesi için kullanılan bir temel sınıftır.
 * Ortak özellikleri paylaşmak için kullanılır.
 * Hem abstract(soyut) hem de normal metodlar içerebilir.
 * Değişken tanımlanabilir.
 * Doğrudan nesne oluşturulamaz.
 * Bir sınıf yalnızca bir abstract sınıftan miras alabilir.*/

using Abstract_Class_1;

Employee employee_1 = new FullTimeEmployee("Mehmet Çelik", 8);
employee_1.Info();
Console.WriteLine($"Salary: {employee_1.CalculateSalary()}");

FullTimeEmployee employee_2 = new FullTimeEmployee("Nazlı Duman", 7);
employee_2.Info();
Console.WriteLine($"Salary: {employee_2.CalculateSalary()}");

Freelancer employee_3 = new Freelancer("Can Koç", 10);
employee_3.Info();
Console.WriteLine($"Salary: {employee_3.CalculateSalary()}");