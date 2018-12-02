using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class bear_move : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    NavMeshPath path;
    public float timeforNewPath;
    bool inCoRoutine;


    Vector3 target;
    bool validPath;


    //to set animation
    public GameObject animate;
    AnimatorController animating;
    bool wait;

    void Awake()
    {
        animating = animate.GetComponent<AnimatorController>();
        wait = true;

    }

        // Use this for initialization
        void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {

        if (!inCoRoutine) {
            
            StartCoroutine(DoSomethig());

        }

        //if(wait)
        //    animating.SetInt("animation, 15");
        //else
        //    animating.SetInt("animation, 1");

    }

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(-10, 10);
        float z = Random.Range(-10, 10);

        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }

    IEnumerator DoSomethig()
    {

        inCoRoutine = true;
        Debug.Log("wait");
        wait = true;
        yield return new WaitForSeconds(timeforNewPath);
        Debug.Log("done wait");
        wait = false;


        GetNewPath();
        validPath = navMeshAgent.CalculatePath(target, path);
        if (!validPath)
            Debug.Log("Found an invalid path");

        while (!validPath)
        {
            //animating.SetInt("animation, 1");
            yield return new WaitForSeconds(0.01f);
           // animating.SetInt("animation, 15");
            GetNewPath();
            validPath = navMeshAgent.CalculatePath(target, path);
        }
        inCoRoutine = false;

    }

    void GetNewPath()
    {
        //animating.SetInt("animation, 15");
        target = getNewRandomPosition();
        navMeshAgent.SetDestination(target);
        //animating.SetInt("animation, 1");

    }




}