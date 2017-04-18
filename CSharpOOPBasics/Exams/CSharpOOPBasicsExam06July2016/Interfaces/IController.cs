namespace _01.KermenExam.Interfaces
{
    public interface IController
    {

        IDatabase Database { get; }

        void PaySalaries();
    }
}
