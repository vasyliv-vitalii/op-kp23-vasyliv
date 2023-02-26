class MyClass
{
    /*TEST SCENARIOS:
     * INPUT : The sea is a vast and beautiful expanse of water that covers more than two-thirds of the Earth's surface. It is home to countless creatures, from tiny plankton to giant whales, and plays a crucial role in our planet's ecosystem.
     * For many people, the sea is a source of relaxation and tranquility. The sound of the waves crashing against the shore can be soothing and calming, and the salty sea air can be invigorating.
     * OUTPUT : (the, 7)
    (sea, 3)
    (is, 3)
    (a, 3)  
    (vast, 1)   
    (and, 5)
    (beautiful, 1)
    (expanse, 1)
    (of, 4)
    (water, 1)
    (that, 1)   
    (covers, 1)
    (more, 1)
    (than, 1)
    (two-thirds, 1)
    (of, 4)
    (the, 7)
    (Earth's, 1)
    (surface, 1)
    (It, 1)
    (is, 3)
    (home, 1)
    (to, 2)
    (countless, 1)
    (creatures, 1)
    (from, 1)
    (tiny, 1)
    (plankton, 1)
    (to, 2)
    (giant, 1)
    (whales, 1)
    (and, 5)
    (plays, 1)
    (a, 3)
    (crucial, 1)
    (role, 1)
    (in, 1)
    (our, 1)
    (planet's, 1)
    (ecosystem, 1)
    (For, 1)
    (many, 1)
    (people, 1)
    (the, 7)
    (sea, 3)
    (is, 3)
    (a, 3)
    (source, 1)
    (of, 4)
    (relaxation, 1)
    (and, 5)
    (tranquility, 1)
    (the, 7)
    (sound, 1)
    (of, 4)
    (the, 7)
    (waves, 1)
    (crashing, 1)
    (against, 1)
    (the, 7)
    (shore, 1)
    (can, 2)
    (be, 2)
    soothing, 1)
    (and, 5)
    (calming, 1)
    (and, 5)
    (the, 7)
    (salty, 1)  
    (sea, 3)
    (air, 1)
    (can, 2)
    (be, 2)
    (invigorating, 1)
     */
    static void Main(string[] args)
    {
        string path = @"D:\kpi23\op-kp23-vasyliv\sem_2_lab_1\Task5\File1.txt";
        StreamReader sr = new StreamReader(path);
    }

    static (string, int) HowMuchTime(string word, string[] arr)
    {
        string name = "";
        int result = 0;
        return (name, result);
    }
    static int LengthOfArray(string text)
    {
        int length = 0;
        string word = "";
        return length;
    }
    static string ToLowers(string s)
    {
        string answer = "";
        return answer;
    }

    static string[] Splits(string text, int length)
    {
        string[] answer = new string[length];
        string word = "";
        return answer;
    }
}