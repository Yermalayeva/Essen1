// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();
int ranNumber = random.Next(100, 1000);

Console.WriteLine(ranNumber);

int firstDigit = ranNumber / 100;
int fhirdDigit = ranNumber % 10;
int resultDigit = firstDigit * 10 + fhirdDigit;

Console.WriteLine(resultDigit);
