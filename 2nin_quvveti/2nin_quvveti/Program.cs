int num = 8;
while (num > 1)
{
    if (num % 2 == 0)
    {
        num = num / 2;
    }
    else
    {
        Console.WriteLine("eded ikinin quvveti deyil");
        return;
    }
}
if (num == 1)
{
    Console.WriteLine("Eded 2nin quvvetidir");

}
else
{
    Console.WriteLine("eded ikinin quvveti deyil");
}