using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private GameObject[] choices; //drag choices in here 
    private TextMeshProUGUI[] choicesText;
    private Story currentStory; //uses Ink
    public bool isPlaying { get; private set; }

    private void Awake(){
        instance = this;
    }

    private void Start(){
        isPlaying = false;

        dialoguePanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        
        //initialize choicesText
        foreach (GameObject choice in choices){
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>(); //get text from each choice
            index++;
        }
    }

    private void Update(){
        if (!isPlaying){
            return;
        }

        if (Input.GetKeyDown(KeyCode.Return)){
            CanContinue();
        }

        if (GameObject.FindWithTag("Sock") && QuestManager.instance.CheckState("Bear") == QuestState.CAN_FINISH || QuestManager.instance.CheckState("Bear") == QuestState.FINISHED){
            Destroy(GameObject.FindWithTag("Sock"));
        }
    }

    public void Bind(Story story){
        story.BindExternalFunction("collectCoconut", () => {
            Manager.hasCoconut = true;
        });

        story.BindExternalFunction("startBreadGame", () => {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        });

        story.BindExternalFunction("collectStar", () => {
            Manager.hasStar = true;
        });


        story.BindExternalFunction("startBigDinosaurGame", () => {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        });


        story.BindExternalFunction("collectSock", () => {
            Manager.hasSock = true;
            if (GameObject.FindGameObjectWithTag("Sock")){
                GameObject sock = GameObject.FindGameObjectWithTag("Sock");
                Destroy(sock);
            }
        });

        story.BindExternalFunction("lockHamsterPosition", () => {
            HamsterDialogueManager.hamsterIsPlaced = true;
        });

        story.BindExternalFunction("collectSunflower", () => {
            Manager.hasSunflower = true;
        });

         story.BindExternalFunction("startTurtle", () => {
            TurtleClickScript.startClicking = true;
        });

        story.BindExternalFunction("startDinosaurGame", () => {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        });

        story.BindExternalFunction("collectCloud", () => {
            Manager.hasCloud = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        });

        story.BindExternalFunction("collectWater", () => {
            Manager.hasWater = true;
        });

        story.BindExternalFunction("placeRamen", () => {
            PlayerSpawn.instance.placeRamen();
        });

        story.BindExternalFunction("switchLamp", (string character) => {
            SwitchLamp.instance.switchSprites(character);
        });

        story.BindExternalFunction("startManateeGame", () => {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        });

        story.BindExternalFunction("finishGame", () => {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        });

         story.BindExternalFunction("changeSprite", (string character) => {
            SwitchSprites.instance.switchSprites(character);
        });

        story.BindExternalFunction("startQuest", (string questid) => {
            if (QuestManager.instance.CheckState(questid).Equals(QuestState.CAN_START)){
                QuestEventsManager.instance.questEvents.StartQuest(questid);
            }
        });

        story.BindExternalFunction("finishQuest", (string questid) => {
            if (QuestManager.instance.CheckState(questid).Equals(QuestState.CAN_FINISH)){
                QuestEventsManager.instance.questEvents.FinishQuest(questid);
            }
        });
    }

    public void EnterDialogue(TextAsset inkJSON){
        currentStory = new Story(inkJSON.text); //uses Ink
        Bind(currentStory);

        isPlaying = true;
        dialoguePanel.SetActive(true);

        CanContinue();
    }

    private void ExitDialogue(){
        isPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void CanContinue(){
        if (currentStory.canContinue){
            
            string line = currentStory.Continue();

            if (!currentStory.canContinue && line.Equals("")){
                ExitDialogue();
            }

            dialogueText.text = line;
            DisplayChoices();

        }
        else {
            ExitDialogue();
        }
    }

    private void DisplayChoices(){
        List<Choice> currentChoices = currentStory.currentChoices; //from Ink
        int index = 0;
        foreach (Choice choice in currentChoices){
            choices[index].gameObject.SetActive(true); //sets game object to active
            choicesText[index].text = choice.text; //set to choice text from Ink
            index++;
        }

        for (int i = index; i < choices.Length; i++){
            choices[i].gameObject.SetActive(false);
        }
        
        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice(){  
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        if (choices.Length > 0){
             EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
        }
    }

    public void MakeChoice(int choiceIndex){
        currentStory.ChooseChoiceIndex(choiceIndex);
    }
}
