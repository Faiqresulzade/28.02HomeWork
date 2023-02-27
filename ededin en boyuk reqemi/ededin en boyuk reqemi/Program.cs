int num = 2163;
//int qaliq = num % 10;
int result=0;
int ilk_mertebe= num % 10;
int novbeti_mertebe=0;
while (num>0)
{
   novbeti_mertebe = (num % 10)%10;
    if (novbeti_mertebe >= ilk_mertebe)
    {
        result=novbeti_mertebe;
    }
    num = num / 10;
}
Console.WriteLine(result);