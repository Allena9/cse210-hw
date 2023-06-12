///<summary>
///The responsibility of an Entry is to hold a promt, response and date.
///</summary>
class Entry
{
    public string prompt;
    public string response;
    public string date;

    public Entry()
    {
        Prompts prompt = new Prompts();
        this.prompt = prompt.GetRandomPrompt();
    }
    //Converts all inputs into a single string
    public string ConvertToString()
    {
        return $"{date}\n{prompt}\n{response}\n";
    }
    //Saves a response into an entry object
    public void Hold(string response, string date)
    {
        this.response = response;
        this.date = date; 
    }

}