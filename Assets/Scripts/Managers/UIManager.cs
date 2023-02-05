using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_Text aButton;
    public TMP_Text bButton;
    public TMP_Text cButton;
    public TMP_Text dButton;



    // Start is called before the first frame update
    void Start()
    {
        questionText.text = "Select a category";

        TextAsset questions = Resources.Load<TextAsset>("Kymysykset");

        string[] data = questions.text.Split('\n');

        

        for (int i = 0; i < data.Length; i++)
        {
            string[] datas = data[i].Split(',');
            for (int d = 0; d < datas.Length; d++)
            {
                Debug.Log(datas[d]);
            }
        }

        // Debug.Log(data[5]);
    }
}
