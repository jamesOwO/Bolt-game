using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMathsEquation : MonoBehaviour
{
    public Text question;
    int number1, number2, total;
    public InputField input;

    void Start()
    {
        number1 = Random.Range(0, 13);
        number2 = Random.Range(0, 13);
        total = number1 * number2;
        question.text = number1 + " X " + number2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(input.text);
    }

}