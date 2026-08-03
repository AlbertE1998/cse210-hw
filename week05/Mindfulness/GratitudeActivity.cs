public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity will help you focus on the positive things in your life by giving you time to think about the people, experiences, and blessings you are grateful for.")
    {
        _prompts = new List<string>
        {
            "What is something you are grateful for today?",
            "Who is someone you are grateful to have in your life?",
            "What is a recent experience that made you happy?",
            "What is something about your family that you appreciate?",
            "What is a personal strength you are grateful for?",
            "What is something in nature that you appreciate?",
            "What is something you have learned that you are grateful for?"
        };
    }

    public void Run()
    {
        StartActivity();

        Random random = new Random();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine();
        Console.WriteLine("Think about the following question:");
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            string prompt = _prompts[random.Next(_prompts.Count)];

            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();

            ShowSpinner(5);

            Console.WriteLine();
        }

        EndActivity();
    }
}