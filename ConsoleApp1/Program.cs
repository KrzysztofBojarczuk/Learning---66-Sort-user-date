// See https://aka.ms/new-console-template for more information

while (true)
{



    Console.WriteLine("Wprwoadź liczbę użytkowników: ");
    int number = int.Parse(Console.ReadLine());

    int[] tablica = new int[number];

    for (int i = 0; i < tablica.Length; i++)
    {
        Console.WriteLine("Wprowadź wiek użytkowników: ");
        tablica[i] = int.Parse(Console.ReadLine());


    }

    for (int i = 0; i < tablica.Length; i++)
    {
        tablica[i] = DateTime.Now.Year - tablica[i];

    }

    for (int i = 0; i < tablica.Length; i++)
    {
        for (int j = i + 1; j < tablica.Length; j++)
        {
            if (tablica[i] > tablica[j])
            {
                int result = tablica[i];
                tablica[i] = tablica[j];
                tablica[j] = result;
            }
        }
    }
    Console.WriteLine("Wiek użytkowników to: ");
    foreach (var item in tablica)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Czy chcesz zakończyć program? Jeśli tak wpisz Tak. Jeśli chcesz dalej kontynować wcisjnij dowolny klawisz: ");
    string user = Console.ReadLine();
    if (user == "Tak" || user == "tak" || user == "TAK")
    {
        break;
    }
}