using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainCharDialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextAsset inkJSON;
    public bool isPlaying { get; private set; }
    private bool waitOnce;

    private Story currentStory; //uses Ink
        
    private void Start(){
        waitOnce = false;
        isPlaying = false;
        dialoguePanel.SetActive(false);
    }

    private void Update(){
        if (QuestManager.finishedCount == 11 && !DialogueManager.instance.isPlaying){
            StartCoroutine(Wait());
        }
        if (!isPlaying){
            return;
        }
        if (Input.GetKeyDown(KeyCode.Return)){
            CanContinue();
        }
    }

    public void Bind(Story story){
        story.BindExternalFunction("finishGame", () => {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        });
    }

    public void EnterDialogue(TextAsset inkJSON){
        currentStory = new Story(inkJSON.text); //uses Ink
        isPlaying = true;
        Bind(currentStory);

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
            dialogueText.text = currentStory.Continue();
        }
        else {
            ExitDialogue();
        }
    }

    private IEnumerator Wait(){  
        yield return new WaitForSeconds(5);
        if (waitOnce == false){
            EnterDialogue(inkJSON);
            waitOnce = true;
        }
    }

}

