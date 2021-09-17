using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ProblemOne();

        //Debug.Log("The most common letter is: " + ProblemTwo("Hello World"));

        /*List<string> myWords = new List<string>();

        myWords.Add("The");
        myWords.Add("cake");
        myWords.Add("is");
        myWords.Add("a");
        myWords.Add("lie");

        Debug.Log(ProblemThree(myWords));*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProblemOne()
    {
        int a = 3;
        int b = 7;

        for(int i = 1; i <= 1000; i++)
        {
            string s = i.ToString();
            if(s.Contains(a.ToString()) && s.Contains(b.ToString()))
            {
                Debug.Log(i);
            }
        }
    }

    char ProblemTwo(string s)
    {
        char result = ' ';

        Dictionary<char, int> letters = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (!letters.ContainsKey(c))
            {
                letters.Add(c, 1);
            }
            else
            {
                letters[c] += 1;
            }
        }

        foreach(var kvp in letters)
        {
            Debug.Log(kvp.Key + " = " + kvp.Value);
        }

        int resultCount = 0;

        foreach (var kvp in letters)
        {
            if(kvp.Value > resultCount)
            {
                result = kvp.Key;
                resultCount = kvp.Value;
            }
        }

        return result;
    }

    string ProblemThree(List<string> words)
    {
        string result = " ";

        foreach(string s in words)
        {
            foreach(char c in s)
            {
                if(!result.Contains(c.ToString()))
                {
                    result += c;
                }
            }
        }    

        return result;
    }
}
