using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RandomMathsEquation : MonoBehaviour
{
    bool correct = false;
    public Text question;
    int number1, number2, total;
    public InputField input;
    int answer;
    void Start()
    {
        number1 = Random.Range(0, 13);
        number2 = Random.Range(0, 13);
        total = number1 * number2;
        question.text = number1 + " X " + number2;
        correct = false;

    }

    // Update is called once per frame
    void Update()
    {
        answer = int.Parse(input.text);
        if(answer == total)
        {
            correct = false;
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("fhial");
        }
    }

}