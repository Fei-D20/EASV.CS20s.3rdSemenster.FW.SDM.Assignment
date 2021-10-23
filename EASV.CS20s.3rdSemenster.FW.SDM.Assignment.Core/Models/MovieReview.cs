using System;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models
{
    public class MovieReview
    {
        public int Reviewer { get;  set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public MovieReview(int reviewer, int movie, int grade, DateTime date)
        {
            Reviewer = reviewer;
            Movie = movie;
            Grade = grade;
            Date = date;
        }

        public override string ToString()
        {
            return $"Reviewer: {Reviewer,8}, Movie: {Movie,8}, Grade: {Grade}, Date: {Date}";
        }
    }
}