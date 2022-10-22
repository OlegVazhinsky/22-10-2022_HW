// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber (string message) {
    int userNumber;
    while (true) {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number)) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не является числом, повторите ввод.");
        }
    } 
    return userNumber;
}

int userNumber = GetNumber("Введите число - ");

for (int i = 1; i <= userNumber; i++) {
    if (i == userNumber) Console.Write($"{Math.Pow(i, 3)}");
    else Console.Write($"{Math.Pow(i, 3)}, ");
}
