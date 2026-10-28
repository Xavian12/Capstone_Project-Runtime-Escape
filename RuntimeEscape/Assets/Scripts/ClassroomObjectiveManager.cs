using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassroomObjectiveManager : MonoBehaviour
{
    public TextMeshProUGUI objectiveText;
    public TextMeshProUGUI progressText;
    public Slider progressBar;

    public int totalChallenges = 3;

    private int completedChallenges = 0;

    void Start()
    {
        UpdateObjectives();
    }

    public void CompleteChallenge()
    {
        if (completedChallenges < totalChallenges)
        {
            completedChallenges++;
            UpdateObjectives();
        }
    }

    void UpdateObjectives()
    {
        if (objectiveText != null)
        {
            if (completedChallenges >= totalChallenges)
            {
                objectiveText.text = "Classroom Tutorial Complete!";
            }
            else
            {
                objectiveText.text = "Find a way to escape the classroom.";
            }
        }

        if (progressText != null)
        {
            progressText.text = "Training Progress: " +
                                completedChallenges + "/" + totalChallenges;
        }

        if (progressBar != null)
        {
            progressBar.maxValue = totalChallenges;
            progressBar.value = completedChallenges;
        }
    }
}