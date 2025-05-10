using UnityEngine;

public class ChangeCurrentTab : MonoBehaviour
{
    [SerializeField]Canvas currentTab;
    public void OpenTab(Canvas tab)
    {
        currentTab.gameObject.SetActive(false);
        currentTab = tab;
        currentTab.gameObject.SetActive(true);
    }
}
