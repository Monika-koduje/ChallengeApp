namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        float ViewPoints { get; }
        void AddPoint(float point);
        void AddPoint(double point);
        void AddPoint(decimal point);
        void AddPoint(int point);
        void AddPoint(long point);
        void AddPoint(sbyte point);
        void AddPoint(short point);
        void AddPoint(uint point);
        void AddPoint(ulong point);
        void AddPoint(ushort point);
        void AddPoint(byte point);
        void AddPoint(string point);
        void AddPoint(char point);
        void AddPoint(bool point);
        Statistics GetStatistics();

    }

}
