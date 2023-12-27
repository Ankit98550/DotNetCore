namespace RepositoryModel.Models.Repository
{
    public class StudentRepository : IStudent
    {
        public Student GetStudent(int id)
        {
            return DataSource().Where(x=>x.rollno==id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return DataSource();
        }
        private List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() {rollno = 1,name="Rohit",standard=4,age=10},
                new Student() {rollno = 2,name="Mohit",standard=4,age=10},
                new Student() {rollno = 3,name="Johit",standard=4,age=10},
                new Student() {rollno = 4,name="Tohit",standard=4,age=10},
            };
        }
    }
}
