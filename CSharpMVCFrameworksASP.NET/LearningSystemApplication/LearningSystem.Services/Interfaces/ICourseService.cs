namespace LearningSystem.Services.Interfaces
{
    public interface ICourseService
    {
        bool IsCourseOpen(int courseId);
        void RegisterToCourse(string userId, int courseId);
        void SignOutFromCourse(string userId, int courseId);
    }
}