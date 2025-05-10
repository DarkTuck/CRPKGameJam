using UnityEngine;

public class ContinueOnClick : MonoBehaviour
{
    public void Continue(int choice)
    {
        InkDialogManager.ChoiceWasMade(choice);
    }
}
