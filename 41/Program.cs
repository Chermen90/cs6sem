using static System.Console;
Write("Введите числа через пробел: ");
//пользователь вводит числа, которые мы кладём в строку, преобразуем в int 
int[] numbers = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine($"Вы ввели {CountPositive(numbers)} положительных чисел");

//метод для поиска положительных чисел
int CountPositive(int[] innum)
{
    int result = 0;
    for(int i = 0; i < innum.Length; i++)
    {
        if(innum[i] > 0)
        {
            result++;
        }
    }
    return result;

}


