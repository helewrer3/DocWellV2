using DocWellV2.Data.Models;

namespace DocWellV2.Utils;

public class NewVisit
{
    public Patient? Patient = null;
    public string PatientName = string.Empty;
    public string Diagnosis = string.Empty;
    public readonly List<Medicine> Medicines = [];
    public string Notes = string.Empty;
    public DateTime CreatedDate;
    
    public void AddNewMedicineEntry() => Medicines.Add(new Medicine());
    
    public void RemoveLastMedicineEntry() => Medicines.RemoveAt(Medicines.Count - 1);

    public void ToggleMedicineWeekDay(int medicineIdx, int idx) => 
        Medicines[medicineIdx].WeeklyFrequency[idx] = 1 - Medicines[medicineIdx].WeeklyFrequency[idx];

    public static string SerializeMedicines(List<Medicine> medicines)
    {
        if (medicines.Count == 0) return string.Empty;
        var ans = string.Empty;
        foreach (var med in medicines)
        {
            ans += $"{Medicine.SerializeMedicine(med)};";
        }
        return ans.Remove(ans.Length - 1, 1);
    }
}