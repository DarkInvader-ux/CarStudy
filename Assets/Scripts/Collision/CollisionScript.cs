using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject Protect;
    public List<GameObject> Protectors = new List<GameObject>();
    public GameObject[] Protecto;
    private int Health = 7;
    public GameObject President;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Health -= 1;
            Debug.Log(Health);
            //Protectors.RemoveAt(3);
            // Destroy(Protectors[3]);
            Destroy(Protect);
            other.gameObject.SetActive(false);
            if(Health <= 0)
            {
                Destroy(President);
            }
            
        }
    }
    
}
