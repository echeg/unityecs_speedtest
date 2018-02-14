#if EcsShmid
using EcsShmid;
#endif    
using Entitas;
using UnityEngine;

public class ShmidTestRun : MonoBehaviour
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
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Shmid\n All"))
        {
            _systems = ShmidSystemCreator.CreateAllSystems();
            _systems.Initialize();
        }
        buttonnum++;
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Shmid\n Only Run"))
        {
            _systems = ShmidSystemCreator.CreateOnlyRunSystems();
            _systems.Initialize();
        }
        buttonnum++;
        
        if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Add entitys"))
        {
            var t0 = Time.realtimeSinceStartup;
            ShmidEntitiesCreator.CreateEntitys(Contexts.sharedInstance.game);
            Debug.Log("Add entitys " + (Time.realtimeSinceStartup - t0));
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
            Debug.Log("Run Iterations_"+Iterations+" time " + (Time.realtimeSinceStartup - t0));
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