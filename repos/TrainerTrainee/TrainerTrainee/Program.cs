
class Trainee
{
    public Trainer trainer { get; set; }
    public List<Training> trainings { get; set; } = new List<Training>();
}
class Trainer
{
    public List<Trainee> trainers { get; set; } = new List<Trainee>();
    public List<Training> trainings { get; set; }=new List<Training>();
}
class Training
{
    public Trainer trainer { get; set; }
    public List<Training> trainings { get; set; }=new List<Training>();
    public List<Course> courses { get; set; } = new List<Course>();

}
class Module
{
    public List<Unit> units { get; set; } = new List<Unit>();

}
class Course 
{ 
    public Training training { get; set; }
    public Technology technology { get; set; }  
    public List<Module> modules { get; set; } = new List<Module>();

    public List<Module> getmodules()
    {
        return modules;
    }
}
class Technology 
{
    public List<Course> courses { get; set; } = new List<Course>();

}
class Unit
{
    private int durationHrs;
    public List<Topic> topics { get; set; } = new List<Topic>();
    public int getDurationHrs()
    {
    return durationHrs;
    }
}
class Topic 
{
   private string Name;
}
 

