string [] array = {"hello","2","world",":-)"};
string [] new_array = new string[5];
int temp = 0;
for (int i = 0 ; i < array.Length;i++)
{   
    if (array[i].Length <=3)
    new_array[temp] = array[i];
    Console.Write($"['{new_array[temp]}']");
    temp++;
}


