﻿using UnityEngine;
using System.Collections.Generic;

public class MyEgoInterface : EgoInterface
{
	static MyEgoInterface()
	{
//        Add Systems here:
        EgoSystems.Add(
			new DelayColliderSystem(),
			new TickSystem(),
			new InputSystem(),		
			new AIMoverSystem(),
			new SnakeHeadSystem(),
			new SnakePregnancySystem(),
			new SnakePartSystem(),	
			new MovementSystem(),
			new EdibleCollisionSystem(),
			new ObstacleCollisionSystem()
        );	
		EgoEvents.AddFront<TickEvent>();
		EgoEvents.AddFront<TriggerEnterEvent>();
    }

    void Start()
    {
    	EgoSystems.Start();
	}
	
	void Update()
	{
		EgoSystems.Update();
	}
	
	void FixedUpdate()
	{
		EgoSystems.FixedUpdate();
	}
}