﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickEvent : EgoEvent {
	public readonly int tick;
	public readonly bool reverse;
	public TickEvent(int tick )
	{
		this.tick = tick;
		this.reverse = false;
	}
}
