int maxNumber = -50;

for (int i = Math.Abs(maxNumber); i >= maxNumber; i -= 10)
{
    Console.WriteLine(i);
}

/*
i -= x -> i = i - x
i *= x -> i = i * x
i += x -> i = i + x
i /= x -> i = i / x
i %= -> i = i % x
i++ -> i = i + 1
i-- -> i = i - 1
Math.Abs - число по модулю
*/