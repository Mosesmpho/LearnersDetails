using LearnersDetails;

class Program
{
    static void Main (string[] args)
    {
        Learner learner = new Learner("Mpho", "Mokubedi", "Male", 24, 'M');

        Console.WriteLine(learner.firstname + " " + learner.lastname + " " + learner.gender + " " + learner.age + " " + learner.initial);
    }
}