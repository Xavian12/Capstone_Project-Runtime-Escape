using UnityEngine;
using TMPro;

public class WhiteboardQuestion : MonoBehaviour
{
    public ClassroomObjectiveManager objectiveManager;

    public TextMeshProUGUI questionText;
    public TextMeshProUGUI[] answerTexts;
    public TextMeshProUGUI feedbackText;

    private int currentQuestion = 0;
    private bool questionCompleted = false;

    private string[] questions =
    {
        "What color is the Sun?",
        "How many days are in a week?",
        "Which planet is known as the Red Planet?",
        "How many sides does a triangle have?",
        "What do bees make?"
    };

    private string[,] answers =
    {
        { "A. Red", "B. Blue", "C. Yellow", "D. Green" },
        { "A. Five", "B. Seven", "C. Ten", "D. Twelve" },
        { "A. Venus", "B. Jupiter", "C. Mars", "D. Saturn" },
        { "A. Four", "B. Three", "C. Five", "D. Six" },
        { "A. Milk", "B. Honey", "C. Water", "D. Bread" }
    };

    private int[] correctAnswers = { 2, 1, 2, 1, 1 };

    void Start()
    {
        currentQuestion = Random.Range(0, questions.Length);
        Debug.Log("Starting whiteboard question: " + questions[currentQuestion]);
        UpdateQuestion();
    }

    public void AnswerA()
    {
        CheckAnswer(0);
    }

    public void AnswerB()
    {
        CheckAnswer(1);
    }

    public void AnswerC()
    {
        CheckAnswer(2);
    }

    public void AnswerD()
    {
        CheckAnswer(3);
    }

    private void CheckAnswer(int selectedAnswer)
    {
        if (questionCompleted)
        {
            return;
        }

        if (selectedAnswer == correctAnswers[currentQuestion])
        {
            questionCompleted = true;

            if (questionText != null)
            {
                questionText.gameObject.SetActive(false);
            }

        foreach (TextMeshProUGUI answerText in answerTexts)
            {
        if (answerText != null)
    {
        answerText.transform.parent.gameObject.SetActive(false);
    }
            }

            if (feedbackText != null)
            {
                feedbackText.text = "CORRECT!\n\nYour next clue lies behind an achievement.";
            }   

            if (objectiveManager != null)
            {
                objectiveManager.CompleteChallenge();
            }
        }
        else
        {
            int nextQuestion = Random.Range(0, questions.Length);

        while (nextQuestion == currentQuestion)
            {
                nextQuestion = Random.Range(0, questions.Length);
            }

                currentQuestion = nextQuestion;
                UpdateQuestion();
        }
    }

    private void UpdateQuestion()
    {
        if (questionText != null)
        {
            questionText.text = questions[currentQuestion];
        }

        for (int i = 0; i < answerTexts.Length && i < 4; i++)
        {
            if (answerTexts[i] != null)
            {
                answerTexts[i].text = answers[currentQuestion, i];
            }
        }

        if (feedbackText != null)
        {
            feedbackText.text = "";
        }
    }
}