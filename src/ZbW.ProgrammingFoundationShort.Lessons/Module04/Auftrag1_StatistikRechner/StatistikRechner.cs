namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern

    int[] zahlen = new int[5];
      for (int i = 0; i < zahlen.Length; i++)
    {
      Console.Write($"Geben Sie Zahl {i + 1} ein: ");
      zahlen[i] = Convert.ToInt32(Console.ReadLine());
    }

    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    //         Console.WriteLine($"Min: {Minimum(zahlen)}, Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");

    Console.WriteLine($"Min: {Minimum(zahlen)}, Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");
  }

  public static int Minimum(int[] zahlen)
  {
    // TODO: Kleinste Zahl finden (Schleife, kein LINQ)
    int min = zahlen[0];
    for (int i = 1; i < zahlen.Length; i++)
    {
      if (zahlen[i] < min)
      { 
        min = zahlen[i];
      }
    }
    return min;
  }

  public static int Maximum(int[] zahlen)
  {
    // TODO: Grösste Zahl finden (Schleife, kein LINQ)
    int max = zahlen[0];
    for (int i = 1; i < zahlen.Length; i++)
    {
      if (zahlen[i] > max)
      {
        max = zahlen[i];
      }
    }
    return max;
  }

  public static double Average(int[] zahlen)
  {
    // TODO: Durchschnitt berechnen (Summe / Länge)
    int sum = 0;
    for (int i = 0; i < zahlen.Length; i++)
    {
      sum += zahlen[i];
    }
    return (double)sum / zahlen.Length;
  }
}
