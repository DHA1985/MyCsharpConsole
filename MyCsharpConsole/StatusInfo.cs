public class StatusInfo
{
    public int StatusID {get; set;}
    public string StatusName {get; set;}
    public StatusInfo(){}
    public StatusInfo(int _StatusID, string _StatusName)
    {
        StatusID = _StatusID;
        StatusName = _StatusName;
    }
    public void ShowStatusName()
    {
        Console.WriteLine(StatusName);
    }
}