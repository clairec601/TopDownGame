using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
public class HamsterDialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject hamster;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextAsset cantPlaceInkJSON;
    
    public bool isPlaying { get; private set; }
    public static bool hamsterIsPlaced;
    public static bool hamsterWasMoved;
    Vector3 position;
    private Story currentStory; //uses Ink
        

    private void Start(){
        isPlaying = false;
        hamsterIsPlaced = false;
        dialoguePanel.SetActive(false);

        if (QuestManager.instance.CheckState("Hamster").Equals(QuestState.FINISHED)){
            hamster.transform.position = position;
        }
    }

    private void Update(){
        if (Input.GetMouseButtonDown(0) && !hamsterIsPlaced && QuestManager.instance.CheckState("Hamster").Equals(QuestState.IN_PROGRESS)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction); //returns raycast

            if (hit.collider == null && !isPlaying) {
                Vector3 position = Input.mousePosition;
                position.z = Camera.main.nearClipPlane;
                hamster.transform.position = Camera.main.ScreenToWorldPoint(position);
                position = hamster.transform.position;
                hamsterWasMoved = true;
            }
            else if (hit.collider.gameObject.tag == "Daisy"){
                Vector3 position = Input.mousePosition;
                position.z = Camera.main.nearClipPlane;
                hamster.transform.position = Camera.main.ScreenToWorldPoint(position);
                position = hamster.transform.position;
                EnterDialogue(cantPlaceInkJSON);
            }
        }

        if (!isPlaying){
            return;
        }
        if (Input.GetKeyDown(KeyCode.Return)){
            CanContinue();
        }
    }


    public void EnterDialogue(TextAsset inkJSON){
        currentStory = new Story(inkJSON.text); //uses Ink
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
            dialogueText.text = currentStory.Continue();
        }
        else {
            ExitDialogue();
        }
    }


}

