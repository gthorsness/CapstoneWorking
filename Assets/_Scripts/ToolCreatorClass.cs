using UnityEngine;
using System.Collections;

public class ToolCreatorClass{
	private static Texture2D fanIcon;
	private static Texture2D balloonIcon;
	private static Texture2D seesawIcon;


	ItemClass fanTool = new ItemClass (0, "Fan", fanIcon, "Fan implementing effects of wind force");
	ItemClass ballonTool = new ItemClass(1,"Balloon",balloonIcon, "Simple balloon meant for carrying things");
	
	public class ItemClass{
		public int Id;
		public string ItemName;
		public string ItemDescription;
		public Texture2D ItemIcon;
		
		public ItemClass(int id,string itemName,Texture2D itemIcon,string itemDescription){
			Id =id;
			ItemName = itemName;
			ItemDescription = itemDescription;
			ItemIcon =itemIcon;
		}
	}
}
	

