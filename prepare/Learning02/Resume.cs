

public class Resume
{
    public string _personsName;

    public List<Job> _jobs = new List<Job>();
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personsName}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}