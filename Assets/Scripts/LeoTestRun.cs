using System.Collections;
using System.Collections.Generic;
using EcsLeo;
using LeopotamGroup.Ecs;
using UnityEngine;

public class LeoTestRun : MonoBehaviour
{
	private EcsWorld _world;
	EcsSystems _systems;

	public int Iterations=1000;
	public bool RunInUpdate;

	void OnGUI()
	{
		var size = 100;
		var offset = 100;
		var buttonnum = 0;
        
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Leo\n All"))
		{
			_world = new EcsWorld();
			_systems = LeoSystemsCreator.CreateAllSystems(_world);
			_systems.Initialize();
		}
		buttonnum++;
        
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Leo\n Only Run"))
		{
			_world = new EcsWorld();
			_systems = LeoSystemsCreator.CreateOnlyRunSystems(_world);
			_systems.Initialize();
		}
		buttonnum++;
		
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Add entitys"))
		{
			var t0 = Time.realtimeSinceStartup;
			LeoEntitiesCreator.CreateEntitys(_world);
			Debug.Log("Add entitys " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;
        
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Run 1"))
		{
			_systems.RunUpdate();
		}
		buttonnum++;

		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Run " + Iterations))
		{
			var t0 = Time.realtimeSinceStartup;
			for (int i = 0; i < Iterations; i++)
			{
				_systems.RunUpdate();
			}
			Debug.Log("Run Iterations " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;
	}
	
	void Update()
	{
		if (!RunInUpdate) return;
		_systems.RunUpdate();
	}
}