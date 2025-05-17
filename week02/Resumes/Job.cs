using System;

// A code template for the category of things knwon as Job. the responsibility of Job
// is to hold and display job titles, name of companies, employee start and end dates
public class Job
{
    // The C# convention is to start member variables with an underscore (_)
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // A method that displays employees' details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}
    