using System.ComponentModel.DataAnnotations;

namespace student_profile.studentprof
{
    public class Class
    {
        public int ID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; } 

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string CivilStatus { get; set; } = string.Empty;

    }
}
