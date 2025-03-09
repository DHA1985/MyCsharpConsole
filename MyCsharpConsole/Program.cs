// this class to call another class
// this class shows you how to create object of class
class Program
{
    static void Main()
    {
        TodoInfo cs = new TodoInfo();
        cs.ID =1;
        cs.TodoName ="Email to customer";
        cs.ShowMe();
        StatusInfo si = new StatusInfo();
        si.StatusID = 1;        
        si.StatusName = "Working";
        si.ShowStatusName();
        StatusInfo si2 = new StatusInfo(2,"Completed");
        si2.ShowStatusName();
        Math m = new Math();
        m.Greeting();

         // Creating an object
        Person person1 = new Person("Alice", 30);
        person1.ShowInfo();

        // Calling static method
        Person.ShowClassInfo();
    }
}