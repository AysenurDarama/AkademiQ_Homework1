/* Interface Nedir?
 * Bir interface, sınıfların uygulaması gereken metotları belirten bir yapıdır
 * İçinde gövdesi olan metotlar bulunmaz.Sadece metod imzalarını içerir.
 * Bir sınıf birden fazla interface uygulayabilir.
 * Field içeremez ama property tanımlanabilir.*/

using Interface_1;

IPayment payment_1 = new CreditCardPayment();
payment_1.ProcessPayment(200);

IPayment payment_2 = new PayPalPayment();
payment_2.ProcessPayment(300.50);
