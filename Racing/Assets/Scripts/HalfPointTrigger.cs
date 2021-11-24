using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    void OnTriggerEnter()
    {
        lapCompleteTrig.SetActive(true);
        halfLapTrig.SetActive(false); 
    }
}