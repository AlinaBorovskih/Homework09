void Rec(int N, int M)
{

    if (N > M)
    {
        return;
    }
    Console.Write(N + " ");
    Rec(N + 1, M);
}

Rec(1, 5);
Console.WriteLine();

void Rec2 (int N, int M)
{

    if (N > M)
    {
        return;
    }
    Rec2(N + 1, M);
    Console.Write(N + " ");
}

Rec2(1, 5);
Console.WriteLine();