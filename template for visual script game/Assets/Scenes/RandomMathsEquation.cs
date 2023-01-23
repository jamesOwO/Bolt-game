using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMathsEquation : MonoBehaviour
{
    public Text question;
    int number1, number2, total;
    // Start is called before the first frame update
    void Start()
    {
        number1 = Random.Range(0, 13);
        number2 = Random.Range(0, 13);
        total = number1 * number2;
        question.text = number1 + "X" + number2;
        Debug.Log(question.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
}
