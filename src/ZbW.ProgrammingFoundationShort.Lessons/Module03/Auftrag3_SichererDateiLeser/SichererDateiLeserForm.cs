using System.Security.Cryptography.Pkcs;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

// ============================================================
// AUFTRAG 3 – SichererDateiLeser (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Liest eine Datei mit try-catch-finally ab und zeigt Zeilen an.
//
// Anforderungen:
//   - TxtPfad: Dateipfad eingeben
//   - try: File.ReadAllLines, for-Schleife mit Zeilennummer
//   - catch FileNotFoundException: eigene Meldung
//   - catch Exception: allgemeiner Fehler
//   - vor dem Lesen CmdLesen deaktivieren, im finally wieder aktivieren
// ============================================================

public partial class SichererDateiLeserForm : Form
{
  public SichererDateiLeserForm()
  {
    InitializeComponent();
  }

 
  private void CmdLesen_Click(object sender, EventArgs e)
  {
    CmdLesen.Enabled = false;
    LstZeilen.Items.Clear();

    // TODO 1: try-catch-finally starten
    try
    {
      string[] zeilen = File.ReadAllLines(TxtPfad.Text);
      for (int i = 0; i < zeilen.Length; i++)
      {
        LstZeilen.Items.Add($"{i + 1}: {zeilen[i]}");
      }
    }
    catch (FileNotFoundException ex)
    {
      MessageBox.Show($"Datei nicht gefunden: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    catch (Exception ex)
    {
      MessageBox.Show($"Allgemeiner Fehler: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
      CmdLesen.Enabled = true;
    }

    // TODO 2: im try-Block:
    //         string[] zeilen = File.ReadAllLines(TxtPfad.Text);
    //         for-Schleife: LstZeilen.Items.Add($"{i+1}: {zeilen[i]}")

    // TODO 3: catch (FileNotFoundException ex):
    //         MessageBox mit Datei-nicht-gefunden-Meldung

    // TODO 4: catch (Exception ex):
    //         MessageBox mit allgemeiner Fehlermeldung

    // TODO 5: finally (läuft immer):
    //         CmdLesen.Enabled = true;
  }
}
