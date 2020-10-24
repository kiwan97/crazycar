using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class HandleTextFile
{
    public static string read_text;
    public string getText()
    {
        return read_text;
    }
    // Start is called before the first frame update
    public void WriteString(string text)
    {
        string path = "Assets/Scripts/coin.txt";
        File.WriteAllText(path, string.Empty);
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(text);
        writer.Close();
        //Debug.Log("WriteString()");
    }
    public void ReadString()
    {
        string path = "Assets/Scripts/coin.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        read_text = reader.ReadToEnd();
        //Debug.Log(reader.ReadToEnd());
       // Debug.Log(read_text + " = text");
        reader.Close();
    }
}

