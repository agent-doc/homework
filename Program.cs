
string[] ruc(int a)
{
    string[] mass = new string[a];
    for(int i = 0; i < a; i++)
    {
        Console.Write("Введите значения {0} элеменат массива: ", i);
        mass[i] = Convert.ToString(Console.ReadLine());
    }
    return mass;
}

string[] homework1(string[] mass, int a)
{
    int m = 0;

    for (int i = 0; i < a; i++)
    {
        if (mass[i].Length > 3)
        {
            m++;
        }
 
    }
    int a_raz = a - m;
    string[] rez = new string[a_raz];
    int b = 0;
    for (int i = 0; i < a; i++)
    {
        if (mass[i].Length <= 3)
        {
            rez[b] = mass[i];
            b++;
        }
    }
    return rez;
}

int dz1_a = 0;
Console.Write("Введите количество элементов массива: ");
dz1_a = Convert.ToInt32(Console.ReadLine());
string[] mass_dz1 = ruc(dz1_a);
Console.WriteLine("Массив: [ {0}{1}", String.Join(", ",mass_dz1)," ]");
string[] rez = homework1(mass_dz1,dz1_a);
Console.WriteLine("Колличество четных элеммента массива: ");
Console.WriteLine("Массив: [ {0}{1}",String.Join(", ", rez)," ]");
