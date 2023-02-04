using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public class QuestionParser : MonoBehaviour
{
    public List<CurrentQuestion> allQuestions;

    public Dictionary<string,List<CurrentQuestion>> allSortedQuestions;
    // Start is called before the first frame update
    void Start()
    {
        allQuestions = Read ("Kymysykset");
        allSortedQuestions = allQuestions.GroupBy(o => o.category).ToDictionary(g => g.Key, g => g.ToList());;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
	static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
	static char[] TRIM_CHARS = { '\"' };

	public static List<CurrentQuestion> Read(string file)
	{
		var list = new List<CurrentQuestion>();
		TextAsset data = Resources.Load (file) as TextAsset;

		var lines = Regex.Split (data.text, LINE_SPLIT_RE);

		if(lines.Length <= 1) return list;

		var header = Regex.Split(lines[0], SPLIT_RE);
		for(var i=1; i < lines.Length; i++) {
            Debug.Log(lines[i]);
			var values = Regex.Split(lines[i], SPLIT_RE);
			if(values.Length == 0 ||values[0] == "") continue;
            CurrentQuestion question = new CurrentQuestion();
            question.currentQuestion = values[0];
            question.aAnswer = values[1];
            question.bAnswer = values[2];
            question.cAnswer = values[3];
            question.dAnswer = values[4];
            question.category = values[5];

			list.Add (question);
		}
		return list;
	}
}
