using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour
{
    public List<NodeController> listaAddNodes;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public NodeController SelectNextNode(){
        int nodeSelected = Random.Range(0,listaAddNodes.Count);
        return listaAddNodes[nodeSelected];
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            other.GetComponent<PlayerController>().ChangeMovePosition(SelectNextNode().gameObject.transform.position);
        }
    }
}
