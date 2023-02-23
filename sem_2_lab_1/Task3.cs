class Class
{
    /*Test  test scenarios
     input:Road, ride, air ,Ambulance, track, Tell, Fire, Check, Mouse, trash, Crash, car, tiger, Our, check.
     output:air, Ambulance, car, Check, check, Crash, Fire, Mouse, Our, ride, Road, Tell, tiger, track, trash.
    */
    string path1 = "D:\\123232323\\Lab3Task3\\Lab3Task3\\TextFile1.txt";
    string path2 = "D:\\123232323\\Lab3Task3\\Lab3Task3\\TextFile2.txt";
    StreamReader sr = new StreamReader(path1);
    int length = 0;
    string[] arrayofwords = new string[length];
    StreamReader sr1 = new StreamReader(path1)
        ShellSort(arrayofwords);
    StreamWriter sw1 = new StreamWriter(path2);
    StreamReader sr2 = new StreamReader(path2);
    Console.WriteLine(sr2.ReadToEnd());
}