// Итоговая контрольная работа. 
string[] array1 = new string[5] {"1234", "1567", "-2", "computer", "123"};
int count = 0;
string[] array2 = new string[ArrLen(count, array1)];
FillArr(array1,array2);


int ArrLen(int count, string[] array)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
        count++;
        }
    }
return count; 
}

void FillArr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

