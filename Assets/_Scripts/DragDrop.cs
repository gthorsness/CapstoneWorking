using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {

		private Color mouseOver = Color.yellow;
		private Color original = Color.clear;
		private bool dragging = false;
		private float distance;
		
		
		void OnMouseEnter()
		{
			renderer.material.color = mouseOver;
		}
		
		void OnMouseExit()
		{
			renderer.material.color = original;
		}
		
		void OnMouseDown()
		{
			distance = Vector3.Distance(transform.position, Camera.main.transform.position);
			dragging = true;
		}
		
		void OnMouseUp()
		{
			dragging = false;
		}
		
		void Update()
		{
			if (dragging)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				Vector3 rayPoint = ray.GetPoint(distance);
			rayPoint.z = transform.position.z;
				transform.position = rayPoint;
			}
		}
	}


