namespace Test
{
    public class Student
    {
        public Student()
        {
        }

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual StudentAddress StudentAddresssss { get; set; }
    }

}
