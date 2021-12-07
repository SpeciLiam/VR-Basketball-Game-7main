using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    //public GameObject toReset;
    public GameObject throwPrefab;
    public Transform resetTransform;
    public Target target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    void OnTriggerEnter()
    {
        /*GameObject inst = GameObject.Instantiate<GameObject>(throwPrefab);
        inst.transform.position = resetTransform.position;
        inst.transform.rotation = resetTransform.rotation;
        //reset the object
        //toReset.transform.rotation = resetTransform.rotation;
        //toReset.transform.position = resetTransform.position;
        //toReset.GetComponent<Rigidbody>().angularVelocity = new Vector3();
        //toReset.GetComponent<Rigidbody>().velocity = new Vector3();
        if(target.gameObject.activeInHierarchy == false)
        {
            target.hits = target.maxhits;
            target.gameObject.SetActive(true);
        }*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
