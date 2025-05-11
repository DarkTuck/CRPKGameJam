using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.InputSystem;

public class InkDialogManager : MonoBehaviour
{
    [SerializeField] GameObject dialogPanel,ContinueButton;
    [SerializeField] TextMeshProUGUI dialogText;
    [SerializeField] GameObject[] dialogButton;
    [SerializeField] TextMeshProUGUI[] dialogButtonText;
    //[SerializeField] PlayerMovement playerMovement;
    private static InkDialogManager instance;
    private Story currentStory;
    [SerializeField] TextAsset storyJSON;
    public bool dialogOpen { get; private set; } = false;
    Actions actions;

    private void Awake()
    {
        currentStory=new Story(storyJSON.text);
        actions = new Actions();
        if (instance == null)
        {
            instance = this;    
        }
    }

    void Start()
    {
        dialogPanel.SetActive(false);
    }

    public void StartDialogue(string knotName="")
    {
        EnterDialog(knotName);
    }

    private void EnterDialog(string knotName="")
    {
        Debug.Log(knotName);
        if (dialogOpen) 
        {
            return;
        }
        actions.Player.ContinueDialog.Enable();
        actions.Player.ContinueDialog.performed += InputContinueStory;
        dialogOpen = true;
        dialogPanel.SetActive(true);
        //playerMovement.enabled = false;
        if (!knotName.Equals(""))
        {
            currentStory.ChoosePathString(knotName);
        }
        else 
        {
            Debug.LogWarning("Knot name was the empty string when entering dialogue.");
        }
        
        ContinueStory();

    }

    public static void ChoiceWasMade(int choice)
    {
        instance.currentStory.ChooseChoiceIndex(choice);
        instance.ContinueStory();
    }

    public void ContinueStoryPublic()
    {
        ContinueStory();
    }
    private void ContinueStory()
    {     
        if (currentStory.canContinue)
        {
            dialogText.text=currentStory.Continue();
            DisplayChoice();
        }
        else
        {
            ExitDialogMode();
        }
    }
    private bool IsLineBlank(string dialogueLine)
    {
        return dialogueLine.Trim().Equals("") || dialogueLine.Trim().Equals("\n");
    }
    private void InputContinueStory(InputAction.CallbackContext context)
    {
        ContinueStory();
    }

    void DisplayChoice()
    {
        List<Choice> currentChoice = currentStory.currentChoices;
        ContinueButton.SetActive(currentChoice.Count <= 0);
        if (currentChoice.Count > dialogButton.Length)
        {
            Debug.LogError("Too many choices");
        }

        for (int i = 0; i <= currentChoice.Count-1; i++)
        {
            dialogButton[i].SetActive(true);
            dialogButtonText[i].text = currentChoice[i].text;

        }

        for (int i = dialogButton.Length-1; i>=currentChoice.Count;i-- )
        {
            dialogButton[i].SetActive(false);
            dialogButtonText[i].text = "";
        }
    }

    void ExitDialogMode()
    {
        dialogPanel.SetActive(false);
        dialogOpen = false;
        currentStory.ResetState();
        actions.Player.ContinueDialog.Disable();
        actions.Player.ContinueDialog.performed -= InputContinueStory;
        //playerMovement.enabled = true;
    }
}