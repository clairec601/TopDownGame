using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSprites : MonoBehaviour
{
    public static SwitchSprites instance { get; private set; }
    [SerializeField] private GameObject mainChar;
    [SerializeField] private GameObject pig;
    [SerializeField] private GameObject bread;
    [SerializeField] private GameObject bigDinosaur;
    [SerializeField] private GameObject bear;
    [SerializeField] private GameObject otter;
    [SerializeField] private GameObject hamster;
    [SerializeField] private GameObject banana;
    [SerializeField] private GameObject dinosaur;
    [SerializeField] private GameObject ramen;
    [SerializeField] private GameObject turtle;

    private int mainCharCount = 0; //switch between having socks and not having socks
    private int bearCount = 0; 
    private int dinosaurCount = 0;
    Animator mainCharAnim;
    Animator pigAnim;
    Animator breadAnim;
    Animator bigDinosaurAnim;
    Animator bearAnim;
    Animator otterAnim;
    Animator hamsterAnim;
    Animator bananaAnim;
    Animator dinosaurAnim;
    Animator ramenAnim;
    Animator turtleAnim;
    private void Awake(){
        instance = this;
        if (Manager.bigDinosaurGameComplete){
            bigDinosaurAnim = bigDinosaur.GetComponent<Animator>();
            bigDinosaurAnim.SetBool("isBigDinosaurAfterIdle", true);
        }
        if (Manager.breadGameComplete){
            breadAnim = bread.GetComponent<Animator>();
            breadAnim.SetBool("isBreadCompleteIdle", true);
        }
    }
    private void Start(){
        pigAnim = pig.GetComponent<Animator>();
        bearAnim = bear.GetComponent<Animator>();
        otterAnim = otter.GetComponent<Animator>();
        hamsterAnim = hamster.GetComponent<Animator>();
        mainCharAnim = mainChar.GetComponent<Animator>();
        bananaAnim = banana.GetComponent<Animator>();
        dinosaurAnim = dinosaur.GetComponent<Animator>();
        ramenAnim = ramen.GetComponent<Animator>();
        turtleAnim = turtle.GetComponent<Animator>();


        if (QuestManager.instance.CheckState("Pig").Equals(QuestState.FINISHED)){
            pigAnim.SetBool("isPigAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Bread").Equals(QuestState.FINISHED)){
            breadAnim.SetBool("isBreadAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Big Dinosaur").Equals(QuestState.FINISHED)){
            bigDinosaurAnim.SetBool("isBigDinosaurAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Otter").Equals(QuestState.FINISHED)){
            otterAnim.SetBool("isOtterAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Banana").Equals(QuestState.FINISHED)){
            bananaAnim.SetBool("isBananaAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Ramen").Equals(QuestState.FINISHED)){
            ramenAnim.SetBool("isRamenAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Bear").Equals(QuestState.FINISHED)){
            bearAnim.SetBool("isBearAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Dinosaur").Equals(QuestState.FINISHED)){
            dinosaurAnim.SetBool("isDinosaurAfterIdle", true);
            dinosaurAnim.SetBool("isDinosaurIdle", false);
        }
        if (QuestManager.instance.CheckState("Hamster").Equals(QuestState.FINISHED)){
            hamsterAnim.SetBool("isHamsterAfterIdle", true);
        }
        if (QuestManager.instance.CheckState("Turtle").Equals(QuestState.FINISHED)){
            turtleAnim.SetBool("isTurtleAfterIdle", true);
            turtleAnim.SetBool("isTurtleIdle", false);
        }

        if (QuestManager.instance.CheckState("Dinosaur").Equals(QuestState.IN_PROGRESS)){
            dinosaurAnim.SetBool("isDinosaurBetweenIdle", true);
            dinosaurAnim.SetBool("isDinosaurIdle", false);
        }
    }
    public void switchSprites(string character){
        if (character.Equals("mainChar") && mainCharCount == 0){
            Vector3 position = mainChar.transform.position;
            Vector3 newPosition = new Vector3(mainChar.transform.position.x - 0.3f, mainChar.transform.position.y, 0);
            mainChar.transform.position = newPosition;

            mainCharAnim.SetBool("isWearingSocks", true);
            mainCharCount++;
        }
        else if (character.Equals("mainChar")){
            mainCharAnim.SetBool("isWearingSocks", false);
            mainCharAnim.SetBool("isForwardIdle", true);
            mainCharCount = 0;
        }
        if (character.Equals("pig")){
            pigAnim.SetBool("isPigAfterIdle", true);
        }
        if (character.Equals("bread")){
            breadAnim.SetBool("isBreadAfterIdle", true);
        }
        if ((character.Equals("bear")) && bearCount == 0){
            bearAnim.SetBool("isBearAfterIdle", true);
            bearCount++;
        }
        else if ((character.Equals("bear")) && bearCount == 1){
            bearAnim.SetBool("isNoSockBearIdle1", true);
            bearCount++;
        }
        else if ((character.Equals("bear")) && bearCount == 2){
            bearAnim.SetBool("isNoSockBearIdle2", true);
            bearCount++;
        }
        else if ((character.Equals("bear")) && bearCount == 3){
            bearAnim.SetBool("isNoSockBearIdle1", false);
            bearAnim.SetBool("isNoSockBearIdle2", false);
            bearAnim.SetBool("isBearAfterIdle", true);
            bearCount = 1;
        }
        if ((character.Equals("otter"))){
            otterAnim.SetBool("isOtterAfterIdle", true);
        }
        if ((character.Equals("hamster"))){
            hamsterAnim.SetBool("isHamsterAfterIdle", true);
        }
        if ((character.Equals("banana"))){
            bananaAnim.SetBool("isBananaAfterIdle", true);
        }
        if ((character.Equals("dinosaur")) && dinosaurCount == 0){
            dinosaurAnim.SetBool("isDinosaurBetweenIdle", true);
            dinosaurCount++;
        }
        else if ((character.Equals("dinosaur")) && dinosaurCount == 1){
            dinosaurAnim.SetBool("isDinosaurBetweenIdle", false);
            dinosaurAnim.SetBool("isDinosaurAfterIdle", true);
        }

        if ((character.Equals("ramen"))){
            ramenAnim.SetBool("isRamenAfterIdle", true);
        }

    }
}
