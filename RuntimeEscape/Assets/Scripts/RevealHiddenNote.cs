
using UnityEngine;

public class RevealHiddenNote : MonoBehaviour
{
    public GameObject hiddenNote;

    public void RevealNote()
    {
        hiddenNote.SetActive(true);
    }
}
