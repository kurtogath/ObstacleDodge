using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 3f;
    
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        onStart();
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            onTimePast();
        }
    }

    void onStart()
    {
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void onTimePast()
    {
        myMeshRenderer.enabled = true;
        myRigidBody.useGravity = true;
    }
}
