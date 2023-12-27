namespace RepositoryModel.Models.Repository
{
    public interface IStudent
    {
        List<Student> GetStudents();

        Student GetStudent(int id);

    }
}
