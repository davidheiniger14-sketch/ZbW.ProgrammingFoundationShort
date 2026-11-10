namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~30 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben, CmdHinzufuegen: Note ins Array
//   - Zähler _anzahl für belegte Plätze, Button deaktivieren, wenn voll
//   - Methoden MIT Parametern: Average/Best/Worst(double[] noten, int anzahl)
//   - LblNoten: Noten sortiert als Komma-Liste (Kopie mit Array.Copy, dann Array.Sort)
//   - LblStats: Durchschnitt, beste und schlechteste Note
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  //         private double[] _noten = new double[10];
  //         private int _anzahl = 0;
  private double[] _noten = new double[10];
  private int _anzahl = 0;

  public NotenVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)
    // TODO 3: Note ins Array schreiben und _anzahl erhöhen
    // TODO 4: Wenn voll: CmdHinzufuegen.Enabled = false;
    // TODO 5: Anzeige aktualisieren (sortierte Kopie + Statistik)
    double.TryParse(TxtNote.Text, out double note);
    double[] notenKopie = new double[_anzahl + 1];
    if (note >= 1.0 && note <= 6.0)
    {
      _noten[_anzahl] = note;
      _anzahl++;
      if (_anzahl == _noten.Length)
      {
        CmdHinzufuegen.Enabled = false;
      }
      Array.Copy(_noten, notenKopie, _anzahl);
      Array.Sort(notenKopie);
      LblNoten.Text = string.Join(", ", notenKopie);
      LblStats.Text = $"Durchschnitt: {Average(_noten, _anzahl):F2}, Beste Note: {Best(_noten, _anzahl):F2}, Schlechteste Note: {Worst(_noten, _anzahl):F2}";
    }
    else
    {
      MessageBox.Show("Bitte geben Sie eine gültige Note zwischen 1.0 und 6.0 ein.");
    }


  }

  private double Average(double[] noten, int anzahl)
  {
    // TODO: Durchschnitt der ersten "anzahl" Noten
    double sum = 0;
    for (int i = 0; i < anzahl; i++)
    {
      sum += noten[i];
    }
    return sum / anzahl;
  }

  private double Best(double[] noten, int anzahl)
  {
    // TODO: Höchste Note finden
    double best = noten[0];
    for (int i = 1; i < anzahl; i++)
    {
      if (noten[i] > best)
      {
        best = noten[i];
      }
    }
    return best;
  }

  private double Worst(double[] noten, int anzahl)
  {
    // TODO: Niedrigste Note finden
    double worst = noten[0];
    for (int i = 1; i < anzahl; i++)
    {
      if (noten[i] < worst)
      {
        worst = noten[i];
      }
    }
    return worst;
  }
}
