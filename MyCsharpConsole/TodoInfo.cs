
//This class will implement property with traditional way
using System;
public class TodoInfo
{
    
    private int _ID;
    private string _todoname;    
   
    
    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    public string TodoName
    {
        get { return _todoname; }
        set { _todoname = value; }
    }
    public TodoInfo() { }
    public TodoInfo(int id, string todoname)
    {
        ID = id;
        TodoName = todoname;       
    }
   
    public void ShowMe()
    {
        Console.WriteLine(TodoName);
    }
}
