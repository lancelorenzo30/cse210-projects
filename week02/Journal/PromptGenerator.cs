public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string chosenPrompt = _prompts[randomIndex];

        return chosenPrompt;
    }
}