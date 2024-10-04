using System;

public class Entry
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
      W02 Prove: Developer—Journal */
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date}: {Prompt}\n{Response}";
    }
}
