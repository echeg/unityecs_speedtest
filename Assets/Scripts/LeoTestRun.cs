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
        
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Leo\n All Sys"))
		{
			var t0 = Time.realtimeSinceStartup;
			_world = new EcsWorld();
			_systems = LeoSystemsCreator.CreateAllSystems(_world);
			_systems.Initialize();
			Debug.Log("Init Leo All Sys " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;
        
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Init Leo\n Only Run Sys"))
		{
			var t0 = Time.realtimeSinceStartup;
			_world = new EcsWorld();
			_systems = LeoSystemsCreator.CreateOnlyRunSystems(_world);
			_systems.Initialize();
			Debug.Log("Init Leo Only Run Sys " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;
		
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Add entitys"))
		{
			var t0 = Time.realtimeSinceStartup;
			LeoEntitiesCreator.CreateEntitys(_world);
			Debug.Log("Add Leo entitys " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;
        
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Run 1"))
		{
			var t0 = Time.realtimeSinceStartup;
			_systems.Run();
			Debug.Log("Run Leo Single Run time " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;

		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Run " + Iterations))
		{
			var t0 = Time.realtimeSinceStartup;
			for (int i = 0; i < Iterations; i++)
			{
				_systems.Run();
			}
			Debug.Log("Run Leo Iterations_"+Iterations+" time " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;
		
		if (GUI.Button(new Rect(offset, buttonnum*size, size, size), "Register Components\n Creation"))
		{
			var t0 = Time.realtimeSinceStartup;
			LeoComponentRegCreators.RegisterComponentCreators();
			Debug.Log("Register Components Creators time " + (Time.realtimeSinceStartup - t0));
		}
		buttonnum++;		
	}
	
	void Update()
	{
		if (!RunInUpdate) return;
		_systems.Run();
	}
}