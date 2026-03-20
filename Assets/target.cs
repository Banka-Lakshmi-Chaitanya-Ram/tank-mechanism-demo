using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Material gothitmaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            GetComponent<MeshRenderer>().material = gothitmaterial;
        }
    }
}
