nt[] dizi = { 3,8,10,11,20,50,55,60,65,70,72,90,91,94,96,99};

int aranan = 55;

int sol = 0, sag = dizi.Length - 1;

while (sol <= sag)

{

    int orta = (sol + sag) / 2;

    if (dizi[orta] == aranan)

    {
        Console.WriteLine("Bulundu! İndeks:" + orta);

        break;

    }

    else if (dizi[orta] < aranan)
    {
        sol = orta + 1;
    }
    else
    {
        sag = orta - 1;
    }
}
  
