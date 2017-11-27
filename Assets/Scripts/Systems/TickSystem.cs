﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickSystem : EgoSystem<
EgoConstraint<Transform, TickComponent>
>{
	public override void Update()
	{
		constraint.ForEachGameObject( ( egoComponent, transform, tick) =>
			{
				int newTick = (int) (Time.time * tick.tickRate);

				if(tick.currentTick<newTick){
					var e = new TickEvent();
					EgoEvents<TickEvent>.AddEvent( e );
					tick.currentTick = newTick;
				}
			} );
	}


}
