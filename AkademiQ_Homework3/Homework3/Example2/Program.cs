using Example2;

BankAccount account1 = new SavingsAccount("Naz Yılmaz",20000);

account1.Info();
account1.CalculateInterest();

BankAccount account2 = new CheckingAccount("Ahmet Demir", 15000);

account2.Info();
account2.CalculateInterest();

