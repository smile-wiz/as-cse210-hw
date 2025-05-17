using System;

public class Resume
{
    public string _name;
    public List<Job>_jobs;

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"{_name} {_jobs}");
    }
}