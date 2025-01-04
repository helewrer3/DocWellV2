namespace DocWellV2.Utils;

public class Medicine
{
    public string Name = string.Empty;
    public int? DailyFrequency = null;
    public readonly List<int> WeeklyFrequency = [0, 0, 0, 0, 0, 0, 0];
    private readonly List<string> _week = ["M", "T", "W", "T", "F", "S", "S"];

    public string GetWeekDay(int idx) => _week[idx];

    public static string SerializeMedicine(Medicine medicine)
    {
        var ans = $"{medicine.Name}|";
        ans += $"{medicine.DailyFrequency.ToString()}|";
        foreach (var w in medicine.WeeklyFrequency)
        {
            ans += $"{w},";
        }
        return ans == string.Empty ? ans : ans.Remove(ans.Length - 1, 1);
    }
}