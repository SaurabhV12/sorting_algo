/*Name : Saurabh Verma
Date :  02/28/2023
Selection Sort Algo
*/

int[] selection_sort_num = { 5, 72, 3, 14, 7 ,1};

Console.WriteLine("The array before executing the Selection Sort: ");
for (int i = 0; i < selection_sort_num.Length; i++)
{
    Console.Write("  " + selection_sort_num[i]);
}
Console.WriteLine("");
Console.WriteLine("The array after executing the Selection Sort: ");
selection_sort(selection_sort_num);
Console.WriteLine("");


static void selection_sort(int[] ss_arr)
{
    int min_pos;
    int temp;

    for (int i = 0; i < ss_arr.Length; i++)
    {
        min_pos = i;
        for (int x = i + 1; x < ss_arr.Length; x++)
        {
            if (ss_arr[x] < ss_arr[min_pos])
            {
                min_pos = x;
            }
        } 
        if (min_pos != i)
        {
            temp = ss_arr[i];
            ss_arr[i] = ss_arr[min_pos];
            ss_arr[min_pos] = temp;
        }
        Console.Write("  " + ss_arr[i]);
    } 
}
