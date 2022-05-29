int sum = 0;

void Rec(int M, int N)
{

    if (M > N)
    {
        return;
    }
    sum +=M;
    Rec(M + 1, N);
}

Rec(1, 15);
Console.WriteLine(sum);