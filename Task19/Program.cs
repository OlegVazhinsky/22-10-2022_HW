int GetNumber (string message) {
    int userNumber;
    while (true) {
        Console.Write(message);
 
        if (int.TryParse(Console.ReadLine(), out int number) && ((number < 100000 && number > 9999) || ((number > -100000 && number < -9999)))) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не является пятизначным числом, повторите ввод.");
        }
    } 
    return userNumber;
}

int userNumber = GetNumber("Введите пятизначное число - ");

if ((userNumber / 10000 == userNumber % 10) && ((userNumber / 1000) % 10 == (userNumber % 100) / 10)) {
    Console.WriteLine($"Число {userNumber} является палиндромом.");
}
else {
    Console.WriteLine($"Число {userNumber} не является палиндромом.");
}
