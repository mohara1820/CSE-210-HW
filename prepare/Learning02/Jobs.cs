using System;

public class Jobs
    {
        public string _jobtitles;
        public string _CompanyName;
        public int _StartingYear;
        public int _endYear;

        public void Display()
        {
            Console.Write($"{_jobtitles} ({_CompanyName}) {_StartingYear}");
        }   
    }