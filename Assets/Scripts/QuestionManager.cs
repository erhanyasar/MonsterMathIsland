using TMPro;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _questionTextField;
    [SerializeField] private TMP_InputField _answerInputField;
    
    private string _question;
    [SerializeField] private float _answer;
    
    // Start is called before the first frame update
    void Start()
    {
        int operand1 = Mathf.FloorToInt(Random.Range(0,100));
        int operand2 = Mathf.FloorToInt(Random.Range(0,100));

        //Is it a + or - question, creates 50% chance
        if (Random.value < 0.5f)
        {
            //using string concatenation
            //_question = operand1 + "-" + operand2 + " = ? ";
            
            //using string interpolation
            _question = $"{operand1} - {operand2} = ?";
            _answer =  (operand1 - operand2);
        }
        else
        {
            //using string concatenation
            //_question = operand1 + "+" + operand2 + " = ? ";
            
            //using string interpolation
            _question = $"{operand1} + {operand2} = ?";
            _answer =  (operand1 + operand2);
        }

        _questionTextField.text = _question;
        
        //Force focus to answer input field
        _answerInputField.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
