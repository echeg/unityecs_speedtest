#if EcsShmid
using EcsSchmid;
#endif    
using Entitas;
using UnityEngine;

public class SchmidTestRun : MonoBehaviour
{
#if EcsShmid
    Systems _systems;

    public int Iterations=1000;
    public bool RunInUpdate;

    
    void OnGUI()
    {
        var size = 100;
        var buttonnum = 0;
        var offset = 0;
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Shmid\n All Sys"))
        {
            _systems = SchmidSystemCreator.CreateAllSystems();
            _systems.Initialize();
            Debug.Log("Init Schmid All Sys");
        }
        buttonnum++;
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Shmid\n Only Run Sys"))
        {
            _systems = SchmidSystemCreator.CreateOnlyRunSystems();
            _systems.Initialize();
            Debug.Log("Init Schmid Only Run Sys");
        }
        buttonnum++;
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Add entitys"))
        {
            var t0 = Time.realtimeSinceStartup;
            SchmidEntitiesCreator.CreateEntitys(Contexts.sharedInstance.game);
            Debug.Log("Add Schmid entitys " + (Time.realtimeSinceStartup - t0));
        }
        buttonnum++;
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Run 1"))
        {
            _systems.Execute();
        }
        buttonnum++;

        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Run " + Iterations))
        {
            var t0 = Time.realtimeSinceStartup;
            for (int i = 0; i < Iterations; i++)
            {
                _systems.Execute();
            }
            Debug.Log("Run Schmid Iterations_"+Iterations+" time " + (Time.realtimeSinceStartup - t0));
        }
        buttonnum++;
    }

    void Update()
    {
        if (!RunInUpdate) return;
        _systems.Execute();
    }
#endif
}