// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например: 456 -> 4; 782-> 8; 918 -> 1

Random random = new Random();
int ranNumber = random.Next(100, 1000);

Console.WriteLine(ranNumber);

int firstDigit = ranNumber / 100;
int secondDigit = ranNumber / 10;
int resultDigit =secondDigit - firstDigit * 10;

Console.WriteLine(resultDigit);
