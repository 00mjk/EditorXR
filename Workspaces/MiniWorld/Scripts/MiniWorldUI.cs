﻿using UnityEngine;

public class MiniWorldUI : MonoBehaviour
{
	public Renderer grid { get { return m_Grid; } }
	[SerializeField]
	private Renderer m_Grid;

	public Transform boundsCube { get { return m_BoundsCube; } }
	[SerializeField]
	private Transform m_BoundsCube;
}