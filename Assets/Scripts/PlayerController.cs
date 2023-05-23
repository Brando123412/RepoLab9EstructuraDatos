using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 vectorToMove;
    [SerializeField] float speed;
    public float energy;
    float currentEnergy;
    bool conditionEnergy = true;
    public float saveEnergy;
    void Start(){
        saveEnergy=energy;
    }

    void Update(){
        if(conditionEnergy ==  true){
            energy= Mathf.Clamp(energy-Time.deltaTime,0,saveEnergy);
            currentEnergy = (speed*(energy*0.05f))*Time.deltaTime;
            if(energy==0){
                conditionEnergy=false;
            }
        }else{
            energy= Mathf.Clamp(energy+(Time.deltaTime*2),0,saveEnergy);
            if(energy==saveEnergy){
                conditionEnergy=true;
            }
        }
        

        transform.position = Vector3.MoveTowards(transform.position, vectorToMove, currentEnergy);
        //transform.position = Vector3.MoveTowards(transform.position, vectorToMove, speed*Time.deltaTime);
    }
    public void ChangeMovePosition(Vector3 destiny){
        vectorToMove= destiny;
    }
    
}
